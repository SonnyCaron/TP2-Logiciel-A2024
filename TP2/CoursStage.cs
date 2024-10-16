using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class CoursStage : Cours
    {
        private int nbSemaines;

        public CoursStage(string nomCours, string descriptionCours, int nbSemaines) : base(nomCours, descriptionCours)
        {
            this.nbSemaines = nbSemaines;
        }
    }
}
