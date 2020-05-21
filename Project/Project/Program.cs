/* AI Interviewer (or Chatty Clerk at a Sandwich Store)
 * Authors: <insert names here>
 * PP1 2020
 */

using System;
using System.Threading;
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
            Console.WindowWidth = 160;
            Dictionary<string, double> Bread = new Dictionary<string, double>();
            Dictionary<string, double> Salad = new Dictionary<string, double>();
            Dictionary<string, double> Filling = new Dictionary<string, double>();
            Dictionary<string, double> Cheese = new Dictionary<string, double>();
            Dictionary<string, double> Sauce = new Dictionary<string, double>();
            Dictionary<string, double> Sides = new Dictionary<string, double>();

            Setpricessauce(Sauce);
            Setpricescheese(Cheese);
            Setpricesbread(Bread);
            Setpricessalad(Salad);
            Setpricesfilling(Filling);
            SideSetPrice(Sides);

            do
            {
                Console.ResetColor();
                Console.Clear();
                Nav();
                Takeorder(Bread, Salad, Filling, Cheese, Sauce, Sides);
            }
            while (true);

            // Console.ReadLine();           

        }
        public static void SetQuestions(string[] questions, int n)
        {
            // string[] q = new string[n];
            questions[0] = "Hey I was wondering what style of music do you like? ";
            questions[1] = "Just curious ... Where would you like to go overseas? ";
            questions[2] = "This might sound like a personal question ... Are you single or married? ";
            questions[3] = "What's your favourite colour? ";
            questions[4] = "You look familiar, what's your surname? ";
            questions[5] = "By the way, where were you born? ";
            questions[6] = "Nice haircut you got there - How old are you? ";
            questions[7] = "Excuse me for asking ... What gender do you identify with, male or female? ";
            questions[8] = "What is your birth month? ";
            questions[9] = "Which sport do you like? ";
        }

        public static void SetLinks(String[] links, int n)
        {
            // string[] q = new string[n];
            links[0] = "What is your favourite ~ band? ";
            links[1] = "I've never been to ~. What's the weather like there? ";
            links[2] = "Have you ever considered not being ~ (wink)? ";
            links[3] = "Not a big fan of ~ myself. My fav. colour is bastard-amber, ever heard of that? ";
            links[4] = "I know a few ~'s, Do you know Tim ~? ";
            links[5] = "Oh you were born in ~? Is that a cool place? ";
            links[6] = "Wow ~! You don't look it ... How old do you think I am? ";
            links[7] = "What's it like being a ~ ? ";
            links[8] = "Born in ~? What star sign is that? ";
            links[9] = "Did you catch that local ~ match last night? ";
        }

        public static void AskQuestion(String[] questions, String[] links, String[] answers, String[] extended, int NUMQUESTIONS)
        {
            // string userInput;
            Random rand = new Random();
            int quesNum;
            bool chosen;
            for (int loop = 0; loop < 2; loop++)
            {
                chosen = false;
                do
                {
                    quesNum = rand.Next(NUMQUESTIONS);
                    if (answers[quesNum] == "0")
                    {
                        // If answer is "0" ask that question 'questions[]'
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("\n" + questions[quesNum]);
                        // userInput = Console.ReadLine();
                        answers[quesNum] = Console.ReadLine();
                        links[quesNum] = links[quesNum].Replace("~", answers[quesNum].ToUpper());
                        chosen = true;
                    }
                    else if (extended[quesNum] == "0")
                    {
                        // Ask link/extended question instead
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write("\n" + links[quesNum]);
                        extended[quesNum] = Console.ReadLine();
                        chosen = true;
                    }

                }
                while (chosen == false);
            }

            Console.ResetColor();
            Console.Clear();
        }

        public static void FillAnswers(String[] answers, String[] extended, int maxQues)
        {
            for (int loop = 0; loop < maxQues; loop++)
            {
                answers[loop] = "0";
                extended[loop] = "0";
            }
        }
        public static void Nav()
        {
            Console.WriteLine("");
        }
        public static void Takeorder(Dictionary<string, double> Bread, Dictionary<string, double> Salad, Dictionary<string, double> Filling, Dictionary<string, double> Cheese, Dictionary<string, double> Sauce, Dictionary<string, double> Sides)
        {
            double total = 0;
            string temp = "";

            const int NUMQUESTIONS = 10;
            string[] answers = new string[NUMQUESTIONS];
            string[] extended = new string[NUMQUESTIONS];
            string[] questions = new string[NUMQUESTIONS];
            string[] links = new string[NUMQUESTIONS];

            FillAnswers(answers, extended, NUMQUESTIONS);
            SetQuestions(questions, NUMQUESTIONS);
            SetLinks(links, NUMQUESTIONS);

            // Test askquestions method
            //do
            //{
            //    AskQuestion(questions, links, answers, extended, NUMQUESTIONS);
            //} while (false);
            // while (true);

            //Bread ------------------------------------------------------------------------------
            Console.WriteLine("Hello Welcome to SandBread");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nWho's the order for today?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". Lets make a sandwich!\n");
            // Console.ReadLine();
            Thread.Sleep(500);

            foreach (KeyValuePair<string, double> item in Bread)
            {
                Console.WriteLine(item.Key);

            }
            Console.WriteLine("\nWhat bread would you like?");
            string bread = Console.ReadLine();
            double price = Bread[bread];
            Console.WriteLine("\nSo you have chosen " + bread + " at " + price.ToString("C"));
            //Console.ReadLine();
            Thread.Sleep(500);
            total = total + price;

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);

            //Filling -----------------------------------------------------------------------------
            foreach (KeyValuePair<string, double> item in Filling)
            {
                Console.WriteLine(item.Key);

            }
            Console.WriteLine("\nWhat filling?");
            string filling = Console.ReadLine();
            price = Filling[filling];
            Console.WriteLine("So you'll have " + filling + " at " + price.ToString("C"));
            //Console.ReadLine();
            Thread.Sleep(500);
            total = total + price;

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);
            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);

            //Cheese -----------------------------------------------------------------------------
            foreach (KeyValuePair<string, double> item in Cheese)
            {
                Console.WriteLine(item.Key);

            }
            string cheese;
            do
            {
                Console.WriteLine("\nAnd which Cheeses?");
                cheese = Console.ReadLine();
                price = Cheese[cheese];
                Console.WriteLine("So " + cheese + " at " + price.ToString("C"));
                //Console.ReadLine();
                Thread.Sleep(500);
                total = total + price;
                Console.WriteLine("\nAnything else? (yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);

            //salad ---------------------------------------------------------------------------------
            foreach (KeyValuePair<string, double> item in Salad)
            {
                Console.WriteLine(item.Key);

            }
            string salad;
            do
            {
                Console.WriteLine("\nSalads?");
                salad = Console.ReadLine();
                price = Salad[salad];
                Console.WriteLine("So you have chosen " + salad + " at " + price.ToString("C"));
                //Console.ReadLine();
                Thread.Sleep(500);
                total = total + price;
                Console.WriteLine("\nWould you like anything else? (yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);
            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);

            //sauce ---------------------------------------------------------------------------------
            foreach (KeyValuePair<string, double> item in Sauce)
            {
                Console.WriteLine(item.Key);

            }
            string sauce;
            do
            {
                Console.WriteLine("\nWhich sauces on that?");
                sauce = Console.ReadLine();
                price = Sauce[sauce];
                Console.WriteLine("So you have chosen " + sauce + " at " + price.ToString("C"));
                //Console.ReadLine();
                Thread.Sleep(500);
                total = total + price;
                Console.WriteLine("\nAnything else? (yes/no)");
                temp = Console.ReadLine();
            } while (temp != "no");

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);
            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);

            //sides --------------------------------------------------------------------------------
            Console.WriteLine("And finally would you like any sides?\n");
            Console.WriteLine("We have: \n");
            foreach (KeyValuePair<String, double> pair in Sides)
            {
                Console.WriteLine("{0}, {1:C}", pair.Key, pair.Value);
            }
            string sidesentered, sides = "";
            do
            {
                sidesentered = Console.ReadLine();
                sides = sides + " " + sidesentered;
                Console.WriteLine("\nWould you like any other sides? (yes/no)");
                temp = Console.ReadLine();

            } while (temp != "no");

            Console.WriteLine("\nYour sides are" + sides);
            // Console.ReadLine();
            Thread.Sleep(500);

            Console.WriteLine("\nYour Order is a: ");
            Console.WriteLine(bread + " bread sandwich with " + filling + " for the filling and " + salad + " for the salad, " + sauce + " sauce and " + cheese + " for the cheese and a" + sides);
            // Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("\nThat brings your total to " + total.ToString("C"));
            // Console.ReadLine();
            Thread.Sleep(500);

            AskQuestion(questions, links, answers, extended, NUMQUESTIONS);
            // AskQuestion(questions, links, answers, extended, NUMQUESTIONS);            

            //Payment(ref total);
        }

        public static void SideSetPrice(Dictionary<string, double> Sides)
        {
            Sides.Add("Sweet Potato Fries", 4.00);
            Sides.Add("Smoked Cheese Champ Mash", 4.00);
            Sides.Add("Homemade Sumo Wedges", 4.00);
            Sides.Add("Fries", 3.20);
            Sides.Add("Spicy Fries", 3.20);
            Sides.Add("Onion Rings", 2.50);
            Sides.Add("Rice", 2.50);
            Sides.Add("Regular Soup", 5.00);
            Sides.Add("Vegan Soup", 6.00);
            Sides.Add("Cheese Roll", 2.50);
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
            Salad.Add("Lettuce", 0);
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
            Sauce.Add("Ranch", .50);
            Sauce.Add("Thousand Island", .60);
        }



        //private static void Menu()
        //{
        //    string name, bread, meat, salad = "", saladentered, sauce = "", sauceentered, cheese = "", cheeseentered, sides = "", sidesentered;



        //    Console.WriteLine("Hello Welcome to SandBread");
        //    Console.WriteLine("Whos the order for today?");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Hello " + name);
        //    Console.ReadLine();

        //    Console.WriteLine("What Bread would you like? We Have:");
        //    Console.WriteLine("White");
        //    Console.WriteLine("Grain");
        //    Console.WriteLine("Garlic");
        //    Console.WriteLine("Cheese");
        //    Console.WriteLine("Gluten Free");

        //    bread = Console.ReadLine();
        //    Console.WriteLine(bread + " bread it is");
        //    Console.ReadLine();

        //    Console.WriteLine("What Meat would you like? We have:");
        //    Console.WriteLine("Chicken");
        //    Console.WriteLine("Pork");
        //    Console.WriteLine("Beef");
        //    Console.WriteLine("Ham");
        //    Console.WriteLine("Meatballs");
        //    Console.WriteLine("Falafel");
        //    Console.WriteLine("Tofu");

        //    meat = Console.ReadLine();
        //    Console.WriteLine(meat + " for the meat");
        //    Console.ReadLine();

        //    Console.WriteLine("What Salads would you like? We have:");
        //    Console.WriteLine("Lettuce");
        //    Console.WriteLine("Spinach");
        //    Console.WriteLine("Tomato");
        //    Console.WriteLine("Carrots");
        //    Console.WriteLine("Onion");
        //    Console.WriteLine("Capsicum");
        //    Console.WriteLine("Olives");
        //    Console.WriteLine("Pickles");
        //    Console.WriteLine("Beetroot");
        //    Console.WriteLine("Mushrooms");

        //    do
        //    {
        //        saladentered = Console.ReadLine();

        //        salad = salad + " " + saladentered;


        //    } while (saladentered != "");

        //    Console.WriteLine("your salads are" + salad);
        //    Console.ReadLine();

        //    Console.WriteLine("What sauces would you like? We have:");
        //    Console.WriteLine("Barbecue");
        //    Console.WriteLine("Aioli");
        //    Console.WriteLine("Thousand Island");
        //    Console.WriteLine("Ranch");
        //    Console.WriteLine("Sweet Chilli");
        //    Console.WriteLine("Mayonaise");

        //    do
        //    {
        //        sauceentered = Console.ReadLine();

        //        sauce = sauce + " " + sauceentered;


        //    } while (sauceentered != "");



        //    Console.WriteLine("Your sauces are" + sauce);
        //    Console.ReadLine();

        //    Console.WriteLine("What chesse would you like? We have:");
        //    Console.WriteLine("Mozzarella");
        //    Console.WriteLine("Cheddar");
        //    Console.WriteLine("Swiss");
        //    Console.WriteLine("American");

        //    do
        //    {
        //        cheeseentered = Console.ReadLine();

        //        cheese = cheese + " " + cheeseentered;


        //    } while (cheeseentered != "");

        //    Console.WriteLine("Your cheese's are" + cheese);
        //    Console.ReadLine();

        //    Console.WriteLine("And finally would you like any sides? We have");
        //    Console.WriteLine("Drinks, The sizes are small, medium or large");
        //    Console.WriteLine("Cookies: Choc chip, M&M and Oat & Raisin");
        //    Console.WriteLine("Muffins: Choc chip, Boysenberry and Banana");

        //    do
        //    {
        //        sidesentered = Console.ReadLine();

        //        sides = sides + " " + sidesentered;


        //    } while (sidesentered != "");

        //    Console.WriteLine("Your sides are" + sides);
        //    Console.ReadLine();

        //    Console.WriteLine("Your Order is a " + bread + " bread with " + meat + " for the meat and" + salad + "for the salad," + sauce + "sauce and" + cheese + "for the cheese and" + sides + "for the sides");
        //    Console.ReadLine();
        //}





        //public static void Results(string[] questions, string[]answers, int NUMQUESTIONS)
        //{
        //    // Show all the questions with the answer next to it
        //    for (int loop = 0; loop < NUMQUESTIONS; loop++)
        //    {
        //        Console.Write($"Question {loop + 1}:".PadLeft(12));
        //        Console.Write($"{questions[loop]}".PadLeft(40));
        //        Console.WriteLine($"{answers[loop]}".PadLeft(10));
        //    }
        //}


    }
}









