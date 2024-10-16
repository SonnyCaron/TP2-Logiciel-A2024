using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Cours : IComparable<Cours>
    {
        private string nom;
        private string description;
        public string Nom
        {
            get { return nom; }
        }
        public string Description 
        { 
            get { return description; } 
        }
        public Cours(string nom, string description)
        {
            this.nom = nom;
            this.description = description;
        }
        public override string ToString()
        {
            return "Cours : "+nom+". "+description;
        }
        public int CompareTo(Cours other)
        {
            return Nom.CompareTo(other.Nom);
        }
    }
}
