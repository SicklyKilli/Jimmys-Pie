using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        private Dictionary<string, double> Bread = new Dictionary<string, double>();

        public void Main()
        {

            Setprices();
            String[] menuItems = new string[] { "Bread", "Meat", "Salad", "Sauces??" };
            Nav();
        }

        public void Hello()
        {
            string name = "";
            Console.WriteLine("Hello Welcome to SandBread");
            Console.WriteLine("Whos the order for today?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        public void Nav()
        {
            Hello();
        }

        public void Setprices()
        {
            
            Bread.Add("White", .80);
            Bread.Add("Grain", .90);
            Bread.Add("Garlic", 1.0);
            Bread.Add("Cheese", 1.0);
            Console.WriteLine(Bread["White"]);

        }
    }
}
