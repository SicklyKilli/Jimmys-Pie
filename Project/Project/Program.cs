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
            var sideMenu = new Dictionary<string, double>();
            sideMenu.Add("Sweet Potato Fries", 4.00);
            sideMenu.Add("Smoked Cheese Champ Mash", 4.00);
            sideMenu.Add("Homemade Sumo Wedges", 4.00);
            sideMenu.Add("Fries", 3.20);
            sideMenu.Add("Spicy Fries", 3.20);
            sideMenu.Add("Onion Rings", 2.50);
            sideMenu.Add("Rice", 2.50);
            sideMenu.Add("Regular Soup", 5.00);
            sideMenu.Add("Vegan Soup", 6.00);
            sideMenu.Add("Cheese Roll", 2.50);
        


        }

        public static void Hello()
        {
            string name = "";
            Console.WriteLine("Hello Welcome to SandBread");
            Console.WriteLine("Whos the order for today?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }        


        public static void Sides()
        {

        }


    }
}
