using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenArray
{
    public class Functions
    {
        public void PrintUserAnswers(string[] questions, int[] userAnswers, int[] answers)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"question:{questions[i]}");
                Console.WriteLine($"your answer:{userAnswers[i]}");
                Console.WriteLine($"correct answer: {answers[i]}");
            }
        }

        public int[] PromptUserForAnswers(string[] questions, int[] userAnswers)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine("uw antwoord:");
                userAnswers[i] = GetUserAnswer();
            }
            return userAnswers;

            //foreach (string question in questions)
            //{
            //    Console.WriteLine(question);
            //}
        }

        private int GetUserAnswer()
        {
            return int.Parse(Console.ReadLine());
        }

        public string[] GetQuestions(int amountOfQuestions = 6)
        {
            string[] questions = new string[amountOfQuestions];
            for (int i = 0; i < amountOfQuestions; i++)
            {
                Console.WriteLine("Gelieve een vraag in te vullen:");
                questions[i] = Console.ReadLine();
            }
            return questions;
        }

        public int[] GetCorrectAnswers(int amountOfAnswers = 6)
        {
            int[] answers = new int[amountOfAnswers];
            for (int i = 0; i < amountOfAnswers; i++)
            {
                Console.WriteLine("Gelieve een antwoord in te vullen:");
                answers[i] = int.Parse(Console.ReadLine());
            }
            return answers;
        }

    }
}
