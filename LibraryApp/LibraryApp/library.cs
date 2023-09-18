using LibraryApp.moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class library<T> where T : libraryitem<T>
    {
        List<T> items = new List<T>();
    }
}
