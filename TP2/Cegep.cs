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
        public Cours? ChercherCours(string cour)
        {
            return cours.Find(cour2 => cour == cour2.Nom);
        }
        public Cours AjouterCoursAutorise(Cours cour)
        {
            if (cours.Contains(cour)) throw new Exception("Le cégep contient déjà ce cours.");
            cours.Add(cour);
            return cour;
        }
        public Programme? ChercherProgramme(string programme)
        {
            return programmes.Find(programme2 => programme == programme2.Nom);
        }
        public Programme AjouterProgramme(string programme)
        {
            if (programmes.Find(programme2 => programme == programme2.Nom) is not null) throw new Exception("Le cégep contient déjà ce programme.");
            Programme output = new Programme(programme);
            programmes.Add(output);
            return output;
        }
    }
}