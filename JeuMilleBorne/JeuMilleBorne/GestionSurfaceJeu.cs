using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMilleBorne
{
    class GestionSurfaceJeu
    {
        private SurfaceJeu plateau = new SurfaceJeu();

        public SurfaceJeu Plateau
        {
            get { return plateau; }
            set { plateau = value; }
        }

        public void CreerPlateau()
        {
            Plateau.CreerSurfaceJeu();
        }

    }
}
