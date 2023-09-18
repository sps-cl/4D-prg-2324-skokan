using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.moduls
{
    internal class DVD
    {
        internal class DVD : libraryitem<DVD>
        {
            public int Capacity { get; }
            public string Author { get; }

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author} a {Capacity} velikost (MB) ");
        }
    }
}
