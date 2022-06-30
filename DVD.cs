using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Documento
    {
        public DVD(string title) : base(title)
        {
        }

        public int Durata { get; set; }
    }
}
