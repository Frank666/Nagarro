using System;

namespace Nagarro.FranciscoEsteban
{
    /// <summary>
    /// Solution: First I taking the string input and I validate the length and I check the if is larger than 2 chars, if not i return the string with zero coincidences
    /// Step 2: I split the string with a blank space separator, my idea is get only the words
    /// Step 3: is 'save' the length of the word in a variable, just like a reference to know the length of the word and this value will be my reference to 'know' the 'next' char/element
    /// Step 4: is validate if the current word of the loop exists in the next position, k variable is my helper to know the next position and I count the coincidences
    /// Step 5: I get the first and the last char of the word 
    /// Step 6: I just join the results and at the end also a blank space 
    /// 
    /// Regarding the performance, well... I'm not an expert on this topic, but I remember is better use loops and try to implement data structures
    /// I think this solution should be something like O(n) because is only one loop to know and validate the chars in each word
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Sol("Smooth");
            Console.ReadKey();
        }
         
        static void Sol(string input)
        {
            if (input.Length == 0)
            {
                Console.Write($"{input}");
            }
            if (input.Length == 1)
            {
                Console.Write($"{input}0{input}");
            }
            string[] array = input.Split(' ');
            foreach (string word in array)
            {
                int k = word.Length;
                int count = 0;
                for (int i = 1; i < k - 1; i++)
                {
                    if (word[i] != word[i + 1])
                    {
                        count++;
                    }
                }
                char firstChar = word[0];
                char lastChar = word[word.Length - 1];
                Console.Write(String.Concat(firstChar, count.ToString(), lastChar) + " ");
            }            
        }         
    }
}