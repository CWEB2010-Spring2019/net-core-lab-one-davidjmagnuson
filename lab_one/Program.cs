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
            string correctAnswers[10] = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string userSelection[10];
            string quizQuestions[10] = {"question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",
                                        "question",};
            string quizQuestionOptions[,] =
                                    {
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                        {"A) <answer>", "B) <answer>", "C) <answer>", "D) <answer>"},
                                    };
            string selection;
            num start
            num EXIT = -1; //sentinel value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
            Console.WriteLine("To get started, please enter a number other than -1 to start the program");
            INPUT start();
            
            while start != EXIT

                    for(num x = 0; x < quizQuestions.Length; x++)
                    {
                        Console.WriteLine(quizQuestions[x]);
                        for(num i = 0; i < quizQuestionOptions.GetLength(1); i++)
                        {
                            Console.WriteLine(quizQuestionOptions[x, i]);
                        }
                        Console.WriteLine("Please enter an Option");
                        INPUT selection 
                        userSelection[x] = selection

                        //check if the useer is correct
                        if(selection == correctAnswers[x])then
                            correct.Add(selection)
                        else
                            wrong.Add("Question: " + (x + 1) + ") " + selection)
                        endif
                    }

                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);

                //determine if they passed
                var results = (correct.Count >= 7) ? "You passed the assessment " : " You didn't pass ";

                //output the wrong questions
                if(wrong.Count > 0)then
                    Console.WriteLine("Listed below are the questions you got wrong");
                    wrong.ForEach(x => { Console.WriteLine(x)});
                endif 

                wrong.Clear()
                correct.Clear()

                Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1");
                input start

            endwhile


            Console.WriteLine("Program has concluded");
        }
    }
}
