using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Programme : IComparable<Session>
    {
        private string nom;
        private List<Session> sessions;
        public string Nom
        {
            get { return nom; }
        }

        public Programme(string nom)
        {
            this.nom = nom;
            sessions = new List<Session>();
        }
        public override string ToString()
        {
            string output = nom;
            foreach (Session session in sessions)
            {
                output += "\n\t" + session.ToString();
            }
            return output;
        }
        public int CompareTo(Session other)
        {
            return Nom.CompareTo(other.Nom);
        }
        public Session? ChercherSessions(string nomSession)
        {
            return sessions.Find(session => session.Nom == nomSession);
        }
        public Session AjouterSession(string nomSession)
        {
            if (ChercherSessions(nomSession) == null) throw new Exception("Le programme contient déjà cette session.");
            sessions.Add(new Session(nomSession));
            return sessions[-1];
        }
    }
}
