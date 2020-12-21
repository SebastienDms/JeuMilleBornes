﻿using System;
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
        /* Récupère les attributs public et static en tableau de valeurs */
        public static object[] GetFieldValues<T>(T obj)
        {
            var fields = obj.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.Static);

            var test = fields
                .Select(field => field.GetValue(null))
                .ToArray();

            return test;
        }
        /* return T changé en bool /!\ */
        public static bool ReceiveData<T>(NetworkStream fluxNetworkStream) where T : class
        {
            //T data = default(T);

            byte[] buffer = new byte[1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int numBytesRead = fluxNetworkStream.Read(buffer, 0, buffer.Length);
                while (fluxNetworkStream.DataAvailable || numBytesRead > 0)
                {
                    if (numBytesRead == 0)
                        numBytesRead = fluxNetworkStream.Read(buffer, 0, buffer.Length);

                    ms.Write(buffer, 0, numBytesRead);
                    numBytesRead = 0;
                }

                /* ms contient toutes les données du flux réseau */
                var data = MemoryStreamToObject<T>(ms); // converti les octets en un model demandé
                return data;
            }
        }
        public static bool MemoryStreamToObject<T>(MemoryStream stream) where T : class
        {
            var binForm = new BinaryFormatter();

            /*stream.Write(arrBytes, 0, arrBytes.Length);*/
            stream.Seek(0, SeekOrigin.Begin);
            //var obj = binForm.Deserialize(stream);
            var obj = GestionDonneesJeux.ReceptionDuReseauGeneral(stream);

            return obj;

        }
    }
}