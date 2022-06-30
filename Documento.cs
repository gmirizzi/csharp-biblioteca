using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        public string id;
        public string title;
        protected int year;
        protected string settore;
        protected string stato;
        protected int scaffale;
        protected Autore author;
    }
}
