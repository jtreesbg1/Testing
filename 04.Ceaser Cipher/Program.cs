using System;

namespace _04.Ceaser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                int position = GetPosition(currChar) + 3;
                char currLetter = ' ';
                if (char.IsUpper(currChar))
                {
                    currChar = (char)((position + 64));
                }
                else if (char.IsLower(currChar))
                {
                    currChar = (char)((position + 96));
                }
                else
                {
                    currChar = (char)position;
                }
                output += currChar;
            }
            Console.WriteLine(output);
        }

        private static int GetPosition(char currChar)
        {
            if (char.IsLetter(currChar) == false)
            {
                return currChar;
            }
            else if (char.IsUpper(currChar))
            {
                //%26
                return (char)(currChar - 64);
            }
            else
            {
                return (char)(currChar - 96);
            }
        }
    }
}
