using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public List<Utente> userList;
        public List<Prestito> loanList;
        public List<Documento> docList;

        public List<Prestito> LoanResearch(string name, string surname)
        {
            List<Prestito> prestitiCercati = new List<Prestito>();
            foreach (Prestito prestito in loanList)
            {
                if (name == prestito.user.name && surname == prestito.user.surname)
                {
                    prestitiCercati.Add(prestito);
                }
            }
            return prestitiCercati;
        }
    }
}
