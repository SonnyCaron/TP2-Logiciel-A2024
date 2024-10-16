using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Session : IComparable<Cours>
    {
        private string nom;
        private List<Cours> cours;
        public string Nom
        {
            get { return nom; }
        }
        public Session(string nom)
        {
            this.nom = nom;
            cours = new List<Cours>();
        }
        public override string ToString()
        {
            string output = nom;
            foreach (Cours cour in cours)
            {
                output += "\n\t"+cour.ToString();
            }
            return output;
        }
        public int CompareTo(Cours other)
        {
            return Nom.CompareTo(other.Nom);
        }
        public Cours AjouterCours(Cours cour)
        {
            cours.Add(cour);
            return cour;
        }
    }
}
