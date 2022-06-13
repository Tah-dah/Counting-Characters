using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, int> charactersPerWord = new Dictionary<char, int>();
            

            Console.WriteLine("Enter text: ");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (char c in Console.ReadLine())
            {
                int count = 0;
                if (charactersPerWord.ContainsKey(c))
                {
                    count = charactersPerWord[c];
                }
                charactersPerWord[c] = count + 1;
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            foreach (KeyValuePair<char, int> pair in charactersPerWord)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }

            //Console.ReadLine();

        }
    }
}
