using System;

namespace PyramidBuilder
{
    class Program
    {
        static string BuildSingleLine(int width, int index)
        {
            string line = "";

            int numberOfStars = (index * 2) + 1;
            int numberOfSpaces = (width - numberOfStars) / 2;

            for (int i = 0; i < numberOfSpaces; i++)
            {
                line += " ";
            }

            for (int i = 0; i < numberOfStars; i++)
            {
                line += "*";
            }

            for (int i = 0; i < numberOfSpaces; i++)
            {
                line += " ";
            }

            return line;
        }

        static string BuildPyramid(int height)
        {
            string output = "";
            int width = (height * 2) - 1;

            for (int h = 0; h < height; h++)
            {
                output += BuildSingleLine(width, h) + "\n";
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to pyramid builder.");

            Console.Write("Please enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            string pyramid = BuildPyramid(height);
            Console.WriteLine(pyramid);
        }
    }
}
