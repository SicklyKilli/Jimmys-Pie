﻿using System;
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
            const int NUMQUESTIONS = 10;
            int loop = 0;
            String[] questions = new string [NUMQUESTIONS];
            String[] answers = new string[NUMQUESTIONS];

            // Put the questions in each element of the array
            questions[0] = "Which BREAD would you like ?";
            questions[1] = "Which MEAT would you like ?";
            questions[2] = "Any salads ?";
            questions[3] = "Which sauces do you like ? (Choose 1)";
            questions[4] = "What's your name by the way ?";
            questions[5] = "Where were you born ?";
            questions[6] = "How old are you ?";
            questions[7] = "Are you a guy or a girl ?";
            questions[8] = "What is your birth month ?";
            questions[9] = "Do you like sports?";

            // Nav();

            // Display each question with key press inbetween
            do
            {
                Showquestion(questions, loop);
                answers[loop] = Console.ReadLine();
                loop++;
            }
            while (loop < NUMQUESTIONS);

            // Show all the questions with the answer next to it
            for (loop = 0; loop < NUMQUESTIONS; loop++)
            {
                Console.Write($"Question {loop + 1}:".PadLeft(12));
                Console.Write($"{questions[loop]}".PadLeft(40));
                Console.WriteLine($"{answers[loop]}".PadLeft(10));
            }

            Console.WriteLine("\n\nPress ENTER to exit the program ...");
            Console.ReadLine();
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

        public static void Showquestion(String[] questions, int loop)
        {
            Console.WriteLine(questions[loop]);
        }
    }
}
