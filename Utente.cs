using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string surname;
        public string name;
        public string email;
        private string password;
        public int number;

        public Utente(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void EffettuaPrestito (int inizio, int fine, Documento doc, Biblioteca biblioteca)
        {
            Prestito newLoan = new Prestito(inizio, fine, doc);
            biblioteca.loanList.Add(newLoan);
        }

        public Documento CercaPerTitolo (string titolo, Biblioteca biblioteca)
        {
            foreach (Documento doc in biblioteca.docList)
            {
                if (titolo == doc.title)
                {
                    return doc;
                }
            }
        }

        public Documento CercaPerCodice (int codice, Biblioteca biblioteca)
        {

        }


    }
}
