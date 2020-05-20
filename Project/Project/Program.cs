using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {

        public static void Main()
        {
            Dictionary<string, double> sideMenu;
            String order1;
            String order2;

            sideMenu = new Dictionary<string, double>()
            {
                {"Sweet Potato Fries", 4.00},
                {"Smoked Cheese Champ Mash", 4.00},
                {"Homemade Sumo Wedges", 4.00},
                {"Fries", 3.20},
                {"Spicy Fries", 3.20},
                {"Onion Rings", 2.50},
                {"Rice", 2.50},
                {"Regular Soup", 5.00},
                {"Vegan Soup", 6.00},
                {"Cheese Roll", 2.50}
            };

            /*foreach (KeyValuePair<String, double> pair in sideMenu)
            {
                Console.WriteLine("{0}, {1:C}", pair.Key, pair.Value);
            }
            */

            Console.WriteLine("Would you like any sides? \n\nWe have:");
            foreach (KeyValuePair<String, double> pair in sideMenu)
            {
                Console.WriteLine("{0}, {1:C}", pair.Key, pair.Value);
            }
            Console.WriteLine("");
            order1 = Console.ReadLine();
            Console.WriteLine("You have ordered " + order1 + ". Anything Else?");
            order2 = Console.ReadLine();
            Console.WriteLine("You have ordered " + order1 + ","+order2+ ". Anything Else?");



            Console.ReadLine();
        }
    }
}

