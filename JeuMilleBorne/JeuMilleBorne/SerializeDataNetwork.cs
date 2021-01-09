using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    public class SerializeDataNetwork
    {
        public static byte[] SendData(params Object[] listObjects)
        {
            MemoryStream memoryStream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            foreach (var obj in listObjects)
            {
                formatter.Serialize(memoryStream, obj);
            }

            return memoryStream.ToArray();
        }
        /*   Récupère les attributs public et static d'une classe
         *   Récupère les différentes valeurs
         *   Envoie les valeur sous forme d'un tableau
         */
        public static object[] GetFieldValues<T>(T obj)
        {
            /* Obtient les attributs de la classe */
            var fields = obj.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.Static);

            /* Obtient les valeurs des attributs trouvés */
            var test = fields
                .Select(field => field.GetValue(null))
                .ToArray();

            return test;
        }
        /* return T changé en bool /!\ */
        public static bool ReceiveData<T>(NetworkStream fluxNetworkStream) where T : class
        {
            byte[] buffer = new byte[1024];
            using (MemoryStream ms = new MemoryStream())
            {
                //int i = 0;
                //do
                //{
                    int numBytesRead = fluxNetworkStream.Read(buffer, 0, buffer.Length);
                    while (fluxNetworkStream.DataAvailable || numBytesRead > 0)
                    {
                        if (numBytesRead == 0)
                            numBytesRead = fluxNetworkStream.Read(buffer, 0, buffer.Length);

                        ms.Write(buffer, 0, numBytesRead);
                        numBytesRead = 0;
                    }

                //    i++;
                //} while (ms.Length == (14600*i));

                /*   ms contient toutes les données du flux réseau
                 *   converti les octets en un model demandé
                 */
                var data = MemoryStreamToObject<T>(ms);
                return data;
            }
        }
        public static bool MemoryStreamToObject<T>(MemoryStream stream) where T : class
        {
            var binForm = new BinaryFormatter();

            stream.Seek(0, SeekOrigin.Begin);

            var obj = GestionDonneesJeux.ReceptionDuReseauGeneral(stream);

            return obj;
        }
    }
}
