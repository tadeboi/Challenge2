using System;

namespace Algorithm3
{
    class Algorithm3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input a word for checking: ");
                string word = Console.ReadLine().ToLower();

                if (word[0] != 's' || word[1] != 'a')
                {
                    Console.WriteLine("The Word you typed in does not start with Sa");
                    Console.ReadLine();
                }
                else
                {
                    int count = word.Length;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == 'e')
                        {
                            count = count - 1;
                        }
                        if (word[i] == 'm')
                        {
                            count = count - 1;
                        }
                    }

                    Console.WriteLine("\n{0} has {1} characters, excluding 'e' and 'm'", word, count);
                    Console.ReadLine();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
