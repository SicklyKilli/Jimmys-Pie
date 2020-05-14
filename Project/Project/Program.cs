using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {


        private static void Menu(string[] args)
        {
            string name, bread, meat, salad = "", saladentered, sauce ="", sauceentered, cheese="", cheeseentered, sides = "", sidesentered;
          
          
            
                        Console.WriteLine("Hello Welcome to SandBread");
                        Console.WriteLine("Whos the order for today?");
                        name = Console.ReadLine();
                        Console.WriteLine("Hello " + name);
            Console.ReadLine();

                        Console.WriteLine("What Bread would you like? We Have:");
                        Console.WriteLine("White");
                        Console.WriteLine("Grain");
                        Console.WriteLine("Garlic");
                        Console.WriteLine("Cheese");
                        Console.WriteLine("Gluten Free");

                        bread = Console.ReadLine();
                        Console.WriteLine(bread + " bread it is");
            Console.ReadLine();

                        Console.WriteLine("What Meat would you like? We have:");
                        Console.WriteLine("Chicken");
                        Console.WriteLine("Pork");
                        Console.WriteLine("Beef");
                        Console.WriteLine("Ham");
                        Console.WriteLine("Meatballs");
                        Console.WriteLine("Falafel");
                        Console.WriteLine("Tofu");

            meat = Console.ReadLine();
            Console.WriteLine(meat + " for the meat");
            Console.ReadLine();
                       
            Console.WriteLine("What Salads would you like? We have:");
            Console.WriteLine("Lettuce");
            Console.WriteLine("Spinach");
            Console.WriteLine("Tomato");
            Console.WriteLine("Carrots");
            Console.WriteLine("Onion");
            Console.WriteLine("Capsicum");
            Console.WriteLine("Olives");
            Console.WriteLine("Pickles");
            Console.WriteLine("Beetroot");
            Console.WriteLine("Mushrooms");         
            
            do
            {
                saladentered = Console.ReadLine();
                
                salad = salad + " " + saladentered;


            } while (saladentered != "") ;

            Console.WriteLine("your salads are" + salad);
            Console.ReadLine();

            Console.WriteLine("What sauces would you like? We have:");
            Console.WriteLine("Barbecue");
            Console.WriteLine("Aioli");
            Console.WriteLine("Thousand Island");
            Console.WriteLine("Ranch");
            Console.WriteLine("Sweet Chilli");
            Console.WriteLine("Mayonaise");

            do
            {
                sauceentered = Console.ReadLine();

                sauce = sauce + " " + sauceentered;


            } while (sauceentered != "");

            

            Console.WriteLine("Your sauces are" + sauce);
            Console.ReadLine();

            Console.WriteLine("What chesse would you like? We have:");
            Console.WriteLine("Mozzarella");
            Console.WriteLine("Cheddar");
            Console.WriteLine("Swiss");
            Console.WriteLine("American");

            do
            {
                cheeseentered = Console.ReadLine();

                cheese = cheese + " " + cheeseentered;


            } while (cheeseentered != "");

            Console.WriteLine("Your cheese's are" + cheese);
            Console.ReadLine();

            Console.WriteLine("And finally would you like any sides? We have");
            Console.WriteLine("Drinks, The sizes are small, medium or large");
            Console.WriteLine("Cookies: Choc chip, M&M and Oat & Raisin");
            Console.WriteLine("Muffins: Choc chip, Boysenberry and Banana");

            do
            {
                sidesentered = Console.ReadLine();

                sides = sides + " " + sidesentered;


            } while (sidesentered != "");

            Console.WriteLine("Your sides are" + sides);
            Console.ReadLine();

            Console.WriteLine("Your Order is a " + bread + " bread with " + meat + " for the meat and" + salad + "for the salad," + sauce + "sauce and" + cheese + "for the cheese and" + sides + "for the sides");
            Console.ReadLine();
        }
    }
}








            
