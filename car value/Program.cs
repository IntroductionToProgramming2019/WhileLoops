/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : car devaluing
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_value
{
    class Program
    {
        static void Main(string[] args)
        {

            int car_value = 0;
            int year_count = 0;
            Console.WriteLine("Please enter the value of your car: ");
            car_value = int.Parse(Console.ReadLine());
            while (year_count < 10)
            {
                Console.WriteLine("Your car value this year is: {00:c}", car_value);
                int depreciate_year = car_value / 100 * 20;
                car_value = car_value - depreciate_year;
                year_count = year_count + 1;
            }

        }
    }
}
