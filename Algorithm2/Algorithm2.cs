using System;

namespace Algorithm2
{
    class Algorithm2
    {
        static void Main(string[] args)
        {
            long result = 0;
            int num = int.MaxValue;
            bool prime = false;

            try
            {
                for (int i = 1; i < num; i++)
                {
                    for (int j = 2; j < num; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            prime = false;

                        }
                    }
                    if (prime)
                    {
                        result = result + i;

                    }
                    prime = true;

                }
                Console.WriteLine("The sum of the prime numbers is {0}", result);
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
