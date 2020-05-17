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
            // Global variables
            const int NUMQUESTIONS = 10;

            
            String[] answers = new string[NUMQUESTIONS];

            // Put the questions in each element of the array
            // These are side/link questions not related to the sandwich menu
            // *** All edits or contributions to the questions are welcome

	    string[] questions = SetQuestions(NUMQUESTIONS);
            

            // PROGRAM START - SHOW title/welcome page etc.
            Nav();

            // MAIN LOOP - edit if necessary
            int loop = 0;
            do
            {
                Menu();

                // Show a question
                Showquestion(questions, loop);
                // Get user input for answer and store in 'answers' array
                answers[loop] = Console.ReadLine();               

                loop++;         // Go to next question
                if (loop > NUMQUESTIONS)
                {
                    loop = 0;
                    Results(questions, answers, NUMQUESTIONS);
                }
            }
            // While Loop forever
            while (true);


            // Unreachable code - but left in anyway
            Console.WriteLine("\n\nPress ENTER to exit the program ...");
            Console.ReadLine();
        }
	
	public static string[] SetQuestions(int n)
        {
            string[] q = new string[n];
            q[0] = "What style of music do you like ?";
            q[1] = "Have you ever considered going vegan ?";
            q[2] = "Are you in a relationship or single ?";
            q[3] = "What's your favourite colour ?";
            q[4] = "What's your name by the way ?";
            q[5] = "Where were you born ?";
            q[6] = "How old are you ?";
            q[7] = "Are you a guy or a girl ?";
            q[8] = "What is your birth month ?";
            q[9] = "Do you like sports?";
            return q;
        }

        private static void Menu()
        {
            string name, bread, meat, salad = "", saladentered, sauce = "", sauceentered, cheese = "", cheeseentered, sides = "", sidesentered;



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


            } while (saladentered != "");

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

       

        public static void Showquestion(String[] questions, int loop)
        {
            Console.WriteLine(questions[loop]);
        }

        public static void Results(string[] questions, string[]answers, int NUMQUESTIONS)
        {
            // Show all the questions with the answer next to it
            for (int loop = 0; loop < NUMQUESTIONS; loop++)
            {
                Console.Write($"Question {loop + 1}:".PadLeft(12));
                Console.Write($"{questions[loop]}".PadLeft(40));
                Console.WriteLine($"{answers[loop]}".PadLeft(10));
            }
        }

        public static void Nav()
        {
            Console.WriteLine("Nav() - Welcome\n");
        }
    }
}








            
