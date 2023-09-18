using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.moduls
{
    internal abstract class libraryitem
    {
        private int Id { get; }
        private string Title { get; }
        public bool IsAvailable { get; set; }

        public libraryitem(int Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
            this.IsAvailable = true;
        }

        public abstract void DisplayInfo();

    }
}
