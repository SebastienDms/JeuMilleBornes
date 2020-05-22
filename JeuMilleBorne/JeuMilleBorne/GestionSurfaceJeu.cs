using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    static class GestionSurfaceJeu
    {
        private static SurfaceJeu plateau = new SurfaceJeu();

        public static SurfaceJeu Plateau
        {
            get { return plateau; }
            set { plateau = value; }
        }

        public static void CreerPlateau()
        {
            Plateau.CreerSurfaceJeu();
        }

    }
}
