using System;

namespace exersice_testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // find the number of upper case characters in "I am On my WaY to SchOol"
            // char sentence = 'I' 'a''m' 'On' 'my' 'WaY' to SchOol
            int count = 0;
            string sentence = "I am On my WaY to SchOol";
            foreach(char c in sentence)
            {
                if (char.IsUpper(c))
                {
                    count++;
                    Console.WriteLine(count);
                }
               
            }
        }

    }
}
