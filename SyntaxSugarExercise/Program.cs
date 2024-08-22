using System;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string reponse;

            if (answer < 9)
            {
                reponse = answer + " less than nine.";
            }
            else
            {
                reponse = answer + "greater than or equal to nine.";
            }
            var response = (answer < 9) ? $"{answer} is less than nine." : $"{answer} is greater than or equal to nine.";
            Console.WriteLine(response);
        }
    }
}
