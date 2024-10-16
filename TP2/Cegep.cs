using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Cegep
    {
        private string nom;
        private List<Cours> cours;
        private List<Programme> programmes;

        public Cegep(string nom)
        {
            this.nom = nom;
            cours = new List<Cours>();
            programmes = new List<Programme>();
        }
        public string Nom
        {
            get { return nom; }
        }
        public override string ToString()
        {
            string output = nom;
            foreach (Programme programme in programmes)
            {
                output += "\n\t" + programme.ToString();
            }
            foreach (Cours cour in cours)
            {
                output += "\n\t" + cour.ToString();
            }
            return output;
        }
        public Cours? ChercherCours(Cours cour)
        {
            return cours.Find(cour2 => cour.Nom == cour2.Nom);
        }
        public Cours AjouterCoursAutorise(Cours cour)
        {
            if (!cours.Contains(cour)) throw new Exception("Le cégep contient déjà ce cours.");
            cours.Add(cour);
            return cour;
        }
        public Programme? ChercherProgramme(Programme programme)
        {
            return programmes.Find(programme2 => programme.Nom == programme2.Nom);
        }
        public Programme AjouterProgramme(Programme programme)
        {
            if (programmes.Contains(programme)) throw new Exception("Le cégep contient déjà ce programme.");
            programmes.Add(programme);
            return programme;
        }
    }
}