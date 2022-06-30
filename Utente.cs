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

        
    }
}
