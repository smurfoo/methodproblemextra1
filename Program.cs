/*
Purpose: Calculate the surface area and volume of a square pyramid from a user inputted side and
height.
Input: baseside,height
Output: volume,surfacearea 
Author: Ilyas
Date: October 19
*/

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace methodproblemextra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char calculateAgain = ' ';
            double side,
                   height,
                   volume,
                   surfaceArea;
            bool isValid = false;
            do
            {
         side = GetSafeDouble("Enter the base side of the pyramid: ");
         height = GetSafeDouble("Enter the height of the pyramid: ");
         volume = CalculateVolume(side, height);
         surfaceArea = CalculateSurfaceArea(side, height);
         Console.WriteLine($"Volume = {volume:f4}");
         Console.WriteLine($"Surface Area = {surfaceArea:f4}");
         Console.Write("Would you like to calculate another pyramid?");
         calculateAgain = char.Parse(Console.ReadLine().ToUpper().Substring(0,1));
         if (calculateAgain != 'Y')
                {
                    isValid = true;
                }
            } while (!isValid);

        } // end of main
        static double GetSafeDouble(string prompt)
        {
            bool isValid = false;
            double number = 0;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = double.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Invalid number ... try again");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Invalid number ... try again");
                }
            } while (!isValid);
            return number;
        } // end of GetSafeDouble
        static double CalculateVolume(double side, double height)
        {
            double volume = 0;
            volume =  SideSquared(side)/3 * height;
            return volume;
        }
        static double SideSquared(double side)
        {
            return side * side;
        } // end of SideSquared
        static double CalculateSurfaceArea(double side, double height)
        {
            double surfaceArea = 0;
            surfaceArea = SideSquared(side) + (2 * side) * (Math.Sqrt(SideSquared(side) / 4 + (height * height)));
            return surfaceArea;
        }
    }
}