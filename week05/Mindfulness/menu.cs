using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    internal class Menu
    {

        public void ShowMenu()
        {
            Console.WriteLine("\nMindfulness App - Select an Activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
        }
    }
}
