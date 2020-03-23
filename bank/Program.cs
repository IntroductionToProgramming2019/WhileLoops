/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : bank interest
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            double starting_value = 0;
            double interestRate = 0;
            double interestInput = 0;
            double years = 0;
            double interest = 0;
            Console.WriteLine("Please enter your initial deposit: ");
            starting_value = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the rate of interest: ");
            interestInput = int.Parse(Console.ReadLine());
            interestRate = interestInput / 100;
            Console.WriteLine("Please enter the number of years: ");
            years = int.Parse(Console.ReadLine());
            double months = years * 12;
            double month_counter = 0;
            while (month_counter <= months)
            {
                //JAN//
                interest = (starting_value * interestRate / 12);
                starting_value = starting_value + interest;
                month_counter = month_counter + 1;
                Console.WriteLine("The amount of interest is {0:c}",interest);
                Console.WriteLine("The amount in your account is {0:c}",starting_value);
            }
        }
    }
}
