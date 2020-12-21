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

            PaquetsDeCartes.ReceptionDuReseau(MSReceive);
            GestionJoueurs.receptionDuReseau(MSReceive);
            
            return true;
        }
    }
}
