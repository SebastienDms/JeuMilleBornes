using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeuMilleBorne
{
    [Serializable]
    public class Joueur : ISerializable
    {
        #region Donnees
        private string pseudo;
        private int points;
        private int num_joueur;
        #endregion
        #region Accesseurs
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Points { get => points; set => points = value; }
        public int Num_joueur { get => num_joueur; set => num_joueur = value; }
        #endregion
        #region Constructeurs
        public Joueur() { }
        public Joueur(string pseudo, int points, int numerojoueur)
        {
            Pseudo = pseudo;
            Points = points;
            Num_joueur = numerojoueur;
        }
        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Pseudo",Pseudo,typeof(string));
            info.AddValue("Points",Points,typeof(int));
            info.AddValue("Numéro",Num_joueur,typeof(int));
        }

        public Joueur(SerializationInfo info, StreamingContext context)
        {
            Pseudo = (string)info.GetValue("Pseudo", typeof(string));
            Points = (int)info.GetValue("Points", typeof(int));
            Num_joueur = (int)info.GetValue("Numéro", typeof(int));
        }
    }
}
