using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public int dal;
        public int al;
        internal Documento doc;
        internal Utente user;

        public Prestito(int dal, int al, Documento doc)
        {
            this.dal = dal;
            this.al = al;
            this.doc = doc;
        }
    }
}
