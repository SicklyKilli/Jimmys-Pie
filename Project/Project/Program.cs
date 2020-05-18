using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        
        public static void Main(string[]args)
        {    
            Dictionary<string, double> Bread = new Dictionary<string, double>();
            Dictionary<string, double> Salad = new Dictionary<string, double>();
            Dictionary<string, double> Filling = new Dictionary<string, double>();
            Dictionary<string, double> Cheese = new Dictionary<string, double>();
            Dictionary<string, double> Sauce = new Dictionary<string, double>();
            Setpricessauce(Sauce);
            Setpricescheese(Cheese);
            Setpricesbread(Bread);
            Setpricessalad(Salad);
            Setpricesfilling(Filling);
            Takeorder(Bread,Salad,Filling,Cheese,Sauce);

        }

        public static void Setpricesbread(Dictionary<string, double> Bread)
        {
            
            Bread.Add("White", .80);
            Bread.Add("Grain", .90);
            Bread.Add("Garlic", 1.00);
            Bread.Add("Cheese", 1.00);
            Bread.Add("Gluten-Free", 1.20);
   
        }
        public static void Setpricessalad(Dictionary<string, double> Salad)
        {

            Salad.Add("Lettuce",  0);
            Salad.Add("Spinach", .60);
            Salad.Add("Tomato", .30);
            Salad.Add("Carrot", .30);
            Salad.Add("Onion", .20);
            Salad.Add("Capsicum", .30);
            Salad.Add("Olives", .40);
            Salad.Add("Pickles", .10);
            Salad.Add("Beetroot", .20);
            Salad.Add("Mushrooms", .30);
                

        }
        public static void Setpricesfilling(Dictionary<string, double> Filling)
        {

            Filling.Add("Chicken", 1.75);
            Filling.Add("Beef", 2.00);
            Filling.Add("Pork Belly", 4.50);
            Filling.Add("Ham", 1.50);
            Filling.Add("Meatballs", 2.20);
            Filling.Add("Falafel", 3.50);
            Filling.Add("Tofu", 3.00);

        }
        public static void Setpricescheese(Dictionary<string, double> Cheese)
        {

            Cheese.Add("Cheddar", .50);
            Cheese.Add("Mozzarella", .80);
            Cheese.Add("Swiss", .80);
            Cheese.Add("American", .30);
            Cheese.Add("Gruyere", 1.00);
            Cheese.Add("Feta", 1.00);
            Cheese.Add("Dairy-Free", 1.20);

        }
        public static void Setpricessauce(Dictionary<string, double> Sauce)
        {

            Sauce.Add("BBQ", .50);
            Sauce.Add("Aioli", .80);
            Sauce.Add("Mayonnaise", .80);
            Sauce.Add("Sweet Chilli", .30);
            Sauce.Add("Ranch", 1.00);
            Sauce.Add("Thousand Island", 1.00);
            Sauce.Add("Chipotle", 1.20);

        }

        public static void Takeorder(Dictionary<string, double> Bread, Dictionary<string, double> Salad, Dictionary<string, double> Filling, Dictionary<string, double> Cheese, Dictionary<string, double> Sauce)
        {
            double total = 0;
            string temp = "";

            //Bread
            foreach (KeyValuePair<string, double> item in Bread)
            {
                Console.WriteLine(item.Key);

            }
            Console.WriteLine("what bread b?");
            string input = Console.ReadLine();
            double price = Bread[input];
            Console.WriteLine("so you have chosen " + input + " at " + price);
            Console.ReadLine();
            total = total + price;

            //Filling
            foreach (KeyValuePair<string, double> item in Filling)
            {
                Console.WriteLine(item.Key);

            }
            Console.WriteLine("what Filling?");
            input = Console.ReadLine();
            price = Filling[input];
            Console.WriteLine("so you have chosen " + input + " at " + price);
            Console.ReadLine();
            total = total + price;

            //Cheese
            foreach (KeyValuePair<string, double> item in Cheese)
            {
                Console.WriteLine(item.Key);

            }
            do
            {
                Console.WriteLine("what Cheese?");
                input = Console.ReadLine();
                price = Cheese[input];
                Console.WriteLine("so you have chosen " + input + " at " + price);
                Console.ReadLine();
                total = total + price;
                Console.WriteLine("Anything else?(yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");

            //salad
            foreach (KeyValuePair<string, double> item in Salad)
            {
                Console.WriteLine(item.Key);

            }
            do
            {
                Console.WriteLine("what salad?");
                input = Console.ReadLine();
                price = Salad[input];
                Console.WriteLine("so you have chosen " + input + " at " + price);
                Console.ReadLine();
                total = total + price;
                Console.WriteLine("Anything else?(yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");

            //sauce
            foreach (KeyValuePair<string, double> item in Sauce)
            {
                Console.WriteLine(item.Key);

            }
            do
            {
                Console.WriteLine("what Sauces?");
                input = Console.ReadLine();
                price = Sauce[input];
                Console.WriteLine("so you have chosen " + input + " at " + price);
                Console.ReadLine();
                total = total + price;
                Console.WriteLine("Anything else?(yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");
            Payment(ref total);
        }
            public static void Payment(ref double total)
        {
            Console.WriteLine("So your total comes to " + total);
            Console.ReadLine();
        }


        
    }
}
