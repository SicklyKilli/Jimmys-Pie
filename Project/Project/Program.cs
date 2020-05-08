using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {

        public static void Main()
        {
            String[] menuItems = new string[] { "Bread", "Meat", "Salad", "Sauces??" };
            Nav();
        }

        public static void Hello()
        {
            string name = "";
            Console.WriteLine("Hello Welcome to SandBread");
            Console.WriteLine("Whos the order for today?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        public static void Nav()
        {
            Hello();
        }
    }
}
