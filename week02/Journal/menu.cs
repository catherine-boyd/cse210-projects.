using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Menu
    {
        public void showMenu()
        {
            Console.WriteLine("1. Add new Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("0. Quit program");
        }
    }
}
