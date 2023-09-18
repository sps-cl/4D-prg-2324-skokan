using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.moduls
{
    internal class book : libraryitem<book>
    {
        public int Pages { get; }
        public string Author { get; }

        public book(int Pages, string Author, int Id, string Title) : base(ID, Title);

        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author} a {Pages}počet stran");
        }
    }


}
