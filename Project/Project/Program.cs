using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {


        static void Main(string[] args)
        {
            string name, bread, meat, salad, sauce, cheese, sides;
          
            
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
            
            switch (salad = Console.ReadLine())
            {
                case "lettuce":
                    salad = salad + "lettuce";
                    break;

                case "spinach":
                    salad = salad + "spinach";
                    break;

                case "tomato":
                    salad = salad + "tomato";
                    break;

                case "carrots":
                    salad = salad + "arrots";
                    break;

                case "onion":
                    salad = salad + "onions";
                    break;

                case "capsicum":
                    salad = salad + "capsicum";
                    break;

                case "olives":
                    salad = salad + "olives";
                    break;

                case "pickles":
                    salad = salad + "pickles";
                    break;

                case "beetroot":
                    salad = salad + "beetroot";
                    break;

                case "mushrooms":
                    salad = salad + "mushrooms";
                    break;

                    default:
                    salad = "No salad";
                    break;
                    

            
            
            }
            

            Console.WriteLine("your salads are " + salad);
            Console.ReadLine();

            Console.WriteLine("What sauces would you like? We have:");
            Console.WriteLine("Barbecue");
            Console.WriteLine("Aioli");
            Console.WriteLine("Thousand Island");
            Console.WriteLine("Ranch");
            Console.WriteLine("Sweet Chilli");
            Console.WriteLine("Mayonaise");

            switch (sauce = Console.ReadLine())
            {
                case "barbecue":
                    sauce = sauce + "barbecue";
                    break;

                case "aioli":
                    sauce = sauce + "aioli";
                    break;

                case "thousand island":
                    sauce = sauce + "thousand island";
                    break;

                case "ranch":
                    sauce = sauce + "ranch";
                    break;

                case "sweet chilli":
                    sauce = sauce + "sweet chilli";
                    break;

                case "mayonaise":
                    sauce = sauce + "mayonaise";
                    break;

                default:
                    sauce = "No sauce";
                    break;


            }

            Console.WriteLine("Your sauces are " + sauce);
            Console.ReadLine();

            Console.WriteLine("What chesse would you like? We have:");
            Console.WriteLine("Mozzarella");
            Console.WriteLine("Cheddar");
            Console.WriteLine("Swiss");
            Console.WriteLine("American");

            switch (cheese = Console.ReadLine())
            {
                

                case "mozzarella":
                    cheese = cheese + "mozzarella";
                    break;

                case "cheddar":
                    cheese = cheese + "cheddar";
                    break;

                case "swiss":
                    cheese = cheese + "swiss";
                    break;

                case "american":
                    cheese = cheese + "american";
                    break;

                default:
                    cheese = "No cheese";
                    break;

            }

            Console.WriteLine("Your cheese's are " + cheese);
            Console.ReadLine();

            Console.WriteLine("And finally would you like any sides? We have");
            Console.WriteLine("Drinks, The sizes are small, medium or large");
            Console.WriteLine("Cookies: Choc chip, M&M and Oat & Raisin");
            Console.WriteLine("Muffins: Choc chip, Boysenberry and Banana");
            
            switch (sides = Console.ReadLine())
            {
                case "small drink":
                    sides = sides + "small drink";
                    break;

                case "medium drink":
                    sides = sides + "medium drink";
                    break;

                case "large drink":
                    sides = sides + "large drink";
                    break;

                case "choc chip cookie":
                    sides = sides + "choc chip cookies";
                    break;

                case "m&m cookie":
                    sides = sides + "m&m cookie";
                    break;

                case "oat & raisin cookie":
                    sides = sides + "oat & raisin cookie";
                    break;

                case "choc chip muffin":
                    sides = sides + "choc chip muffin";
                    break;

                case "boysenberry muffin":
                    sides = sides + "boysenberry muffin";
                    break;

                case "banana muffin":
                    sides = sides + "banana muffin";
                    break;

                default:
                    sides = "no sides";
                    break;

            }

            Console.WriteLine("Your sides are " + sides);
            Console.ReadLine();

            Console.WriteLine("Your Order is a " + bread + " bread with " + meat + " for the meat and " + salad + " for the salad, " + sauce + " sauce and " + cheese + " for the cheese and " + sides);
            Console.ReadLine();
        }
    }
}








            
