using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyChallenge
{
    class WeeklyChallenge
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> newspapers = new List<string>();
                List<decimal> averages = new List<decimal>();

                Console.WriteLine("Welcome to Newspaper Predictor!\n");

                Console.WriteLine("How many brands of Newspaper do you sell? ");
                int brands = int.Parse(Console.ReadLine());

                for (int i = 0; i < brands; i++)
                {
                    Console.WriteLine("What is the name of your Newspaper {0}: ", i + 1);
                    string paperName = Console.ReadLine();
                    newspapers.Add(paperName);
                    Console.WriteLine("Input the quantity of {0} Newspapers you sold in Week 1", paperName);
                    int quantity1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the price of each {0} Newspaper sold in Week 1", paperName);
                    decimal price1 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Input the quantity of {0} Newspapers you sold in Week 2", paperName);
                    int quantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the price of each {0} Newspaper sold in Week 2", paperName);
                    decimal price2 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Input the quantity of {0} Newspapers you sold in Week 3", paperName);
                    int quantity3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the price of each {0} Newspaper sold in Week 3", paperName);
                    decimal price3 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Input the quantity of {0} Newspapers you sold in Week 4", paperName);
                    int quantity4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the price of each {0} Newspaper sold in Week 4", paperName);
                    decimal price4 = decimal.Parse(Console.ReadLine());

                    decimal average = ((quantity1 * price1) + (quantity2 * price2) + (quantity3 * price3) + (quantity4 * price4)) / 4;
                    averages.Add(average);
                }
                decimal greatest = averages.Max();
                int index = averages.FindIndex(a => a.Equals(greatest));

                string recommended = newspapers[index];
                Console.WriteLine("\nThe Newspaper you should collect most is {0} because it has the highest average of {1:C}", recommended, greatest);
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            

        }

       
    }
}
