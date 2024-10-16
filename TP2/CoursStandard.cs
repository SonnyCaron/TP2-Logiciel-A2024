using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class CoursStandard : Cours
    {
        private int nbEtudiantsMax;

        public CoursStandard(string nomCours, string descriptionCours, int nbEtudiantsMax) : base(nomCours, descriptionCours)
        {
            this.nbEtudiantsMax = nbEtudiantsMax;
        }
    }
}
