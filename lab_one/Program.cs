//D.Magnuson

//using statements
using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main()
        {
            //declaration statements
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] userSelection;
            string[] quizQuestions = {"When was .NET core released?",
                                        "Who developed .NET Core?",
                                        "What is the current version of .NET core?",
                                        "What language is .NET core written in?",
                                        "What operating system is .NET core for?",
                                        "What kind of framework is .NET core?",
                                        ".NET core is a type of what?",
                                        "When was the current version of .NET core released?",
                                        "The host for a .NET core web application is configured in what kind of file?",
                                        "Every command in .NET core command line starts with...?",};
            string[ , ] quizQuestionOptions =
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
                                        {"A) dotnet", "B) .net", "C) dot", "D) dotcore"},
                                    };
            string selection;
            double start;
            double EXIT = -1; //sentinel value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
            Console.WriteLine("To get started, please enter a number other than -1 to start the program");
            start = Console.ReadKey();

            while (start != EXIT)
            {

                for (double x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine(quizQuestions[x]);
                    for (num i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        Console.WriteLine(quizQuestionOptions[x, i]);
                    }
                    Console.WriteLine("Please enter an Option");
                    selection = Console.ReadKey();
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
                }
                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);

                //determine if they passed
                var results = (correct.Count >= 7) ? "You passed the assessment " : " You didn't pass ";

                //output the wrong questions
                if (wrong.Count > 0)
                {
                    Console.WriteLine("Listed below are the questions you got wrong");
                    wrong.ForEach(x => { Console.WriteLine(x);});
                }

                wrong.Clear();
                correct.Clear();
                userSelection.Clear();

                Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1");
                start = Console.ReadKey();

            }

            Console.WriteLine("Program has concluded");
        }
    }
}
