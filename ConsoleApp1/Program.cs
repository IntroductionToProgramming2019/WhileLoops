/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : average of five test scores
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_five_test_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int total = 0;
            int average_test_score = 0;
            int userInput = 0;
            while (userInput != -999)
            {
                Console.WriteLine("Please enter your test score: ");
                userInput = int.Parse(Console.ReadLine());
                total = total + userInput;
                counter = counter + 1;
            }
            average_test_score = total / counter;
            Console.WriteLine("The average test score is {0}", average_test_score);

        }
    }
}