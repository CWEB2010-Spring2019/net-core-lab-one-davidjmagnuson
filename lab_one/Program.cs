//D.Magnuson

//using statements
using System;
using System.Collections.Generic;

namespace lab_one
{
    internal class Program
    {
        private static void Main()
        {
            //declaration statements
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] userSelection = new string[10];
            string[] quizQuestions = {"1. When was .NET core released?",
                                        "2. Who developed .NET Core?",
                                        "3. What is the current version of .NET core?",
                                        "4. What language is .NET core written in?",
                                        "5. What operating system is .NET core for?",
                                        "6. What kind of framework is .NET core?",
                                        "7. .NET core is a type of what?",
                                        "8. When was the current version of .NET core released?",
                                        "9. The host for a .NET core web application is configured in what kind of file?",
                                        "10. Every command in .NET core command line starts with...?",};
            string[,] quizQuestionOptions =
                                    {
                                        {"A) 2005", "B) 2016", "C) 2012", "D) 2015"},
                                        {"A) Intel", "B) Microsoft", "C) Apple", "D) Google"},
                                        {"A) 1.3", "B) 2.1", "C) 2.2", "D) 5.0"},
                                        {"A) C#", "B) Python", "C) Swift", "D) Java"},
                                        {"A) Windows", "B) Linux", "C) MacOS", "D) All the above"},
                                        {"A) open-sourced", "B) lisenced", "C) irrelevant", "D) GUI"},
                                        {"A) software", "B) hard drive", "C) CPU", "D) RAM"},
                                        {"A) 2011", "B) 2016", "C) 2018", "D) 2019"},
                                        {"A) program.py", "B) startup.cs", "C) middleware", "D) program.cs"},
                                        {"A) dotnet", "B) .net", "C) dot", "D) dotcore"}
                                    };
            string selection;
            string start;
            string EXIT = "X"; //sentinel value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
            Console.WriteLine("To get started, please press the Enter key");
            start = Console.ReadLine();

            while (start != EXIT)
            {
                Console.Clear();
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine(quizQuestions[x]);
                    for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        Console.WriteLine(quizQuestionOptions[x, i]);
                    }
                    Console.WriteLine("Please enter an Option");
                    selection = Console.ReadLine();
                    userSelection[x] = selection;

                    //check if the user is correct
                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
                    }
                    else
                    {
                        wrong.Add("Question: " + (x + 1) + ") " + selection);
                    }
                    Console.Clear();
                }
                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);

                //determine if they passed
                var results = (correct.Count >= 7) ? "You passed the assessment " : " You didn't pass ";

                //output the wrong questions
                if (wrong.Count > 0)
                {
                    Console.WriteLine("Listed below are the questions you got wrong");
                    wrong.ForEach(x => { Console.WriteLine(x); });
                }

                wrong.Clear();
                correct.Clear();

                Console.WriteLine("To take the quiz again, please press any key except 'X'. To exit enter 'X'");
                start = Console.ReadLine();

            }
            Console.WriteLine("Program has concluded");

        }
    }
}