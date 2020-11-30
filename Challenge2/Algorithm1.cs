using System;

namespace Challenge2
{
    class Algorithm1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Create()); 
            Console.ReadLine();
        }
        public static bool Create()
        {
            try
            {
                Console.WriteLine("Please Input the first Number: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Input Second Number: ");
                int second = int.Parse(Console.ReadLine());
                int sum = first + second;

                if (sum == 30 || first == 30 || second == 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
       
            
        }
    }
}
