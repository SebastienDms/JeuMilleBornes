using System;
using System.IO;

namespace JeuMilleBorne
{
    [Serializable]
    public class GestionDonneesJeux
    {
        public static PaquetsDeCartes PaquetsDeCartes { get; set; }
        
        public static GestionJoueurs GestionJoueurs { get; set; }

        public static bool ReceptionDuReseauGeneral(MemoryStream MSReceive)
        {
            MSReceive.Seek(0, SeekOrigin.Begin);

            /* Deserialize les paquets de cartes */
            var pos = PaquetsDeCartes.ReceptionDuReseau(MSReceive);
            
            /* Se positionne dans le flux au début des données des infos joueurs*/
            MSReceive.Seek(pos, SeekOrigin.Begin);

            /* Deserialize les infos des joueurs */
            GestionJoueurs.receptionDuReseau(MSReceive);
            
            return true;
        }
    }
}
