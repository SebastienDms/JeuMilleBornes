using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    class SurfaceJeu
    {
        // 5 division sur la hauteur de la PB
        // 8 division sur la largeur de la PB
        // 1000/5 et 1600/8 ==> zone de jeu de 200*200 ==> 127*180
        private List<Point> zones = new List<Point>();

        public List<Point> Zones
        {
            get { return zones; }
            set { zones = value; }
        }

        public void CreerSurfaceJeu()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Zones.Add(new Point(j*205, i*185));
                }
            }
        }
    }
}
