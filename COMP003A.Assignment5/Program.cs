// Author: Kyle James
// Course: COMP003A
// Purpose: Code for Assignment 5
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("\tTriangle Section");
            Console.Write("Enter a single character: ");
            char singleChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(singleChar, num);
            PrintSeparator("\tFavorite Characters Section");
            CharacterInfo("Mario", 1985);
            CharacterInfo("Monkey D. Luffy", 1997);
            CharacterInfo("Sam Fisher", 2002);
            CharacterInfo("Arbiter", 2004);
            CharacterInfo("Master Chief", 2001);
            CharacterInfo("Maximus Decimus Meridius", 2000);
        }

        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Prints the user's string input between 2 rows of characters as separators
        /// </summary>
        /// <param name="separator">Accepts string input</param>
        static void PrintSeparator(string separator)
        {
            PrintSeparator();
            Console.WriteLine(separator);
            PrintSeparator();
        }

        /// <summary>
        /// Prints an isosceles triangle to the console based on 2 parameters
        /// </summary>
        /// <param name="inputCharacter">Character used to build the triangle</param>
        /// <param name="size">Integer that is used to determine the size of the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string input = Convert.ToString(inputCharacter);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(input);
                input += inputCharacter;
            }

            for (int i = size - 1; i >= 1; i--)
            {
                string print = input.Substring(0, i);
                Console.WriteLine(print);
            }

        }

        /// <summary>
        /// Takes a birth year as a parameter and returns the age of the user
        /// </summary>
        /// <param name="year"> Takes user's birth year as an argument</param>
        /// <returns>Returns the age of the user based on what year they input</returns>
        static int AgeCalculator(int year)
        {
            int currentYear = 2024;
            return currentYear - year;
        }

        /// <summary>
        /// Takes a name and birthyear input then displays to the console the name and how old they will be this year
        /// </summary>
        /// <param name="name">User's name</param>
        /// <param name="birthYear">User's birth year</param>
        static void CharacterInfo(string name, int birthYear)
        {
            Console.WriteLine($"{name} turns {AgeCalculator(birthYear)} this year!");
        }
    }
}
