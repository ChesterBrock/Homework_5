/// Chapter No. 5		Exercise No. 2
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Sep 20, 2021
///
/// Problem Statement:  print out statistics for eight coin tosses.
/// 
/// 
/// Overall Plan:
/// 1) Prompt the user for either heads or tails 
/// 2) Loop though 8 times and see if the users places h or t
/// 3) Calculate and print out the total percentage for the flips 
///
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0, tails = 0;
            Console.WriteLine("This is a Heads and Tails simulator. Please enter h or t 8 times");
            // Create a loop that will prompt the user 8 times to enther either heads or tails
            for(int i = 1; i <= 8; i++)
            {
                Console.WriteLine("#" + i + " Please enter a h or t. ");
                if(Console.ReadLine() == "h")
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("Number of heads = " + heads + "\n");
            Console.WriteLine("Number of tails = " + tails + "\n");

            //Percentages
            double headPercent = Convert.ToDouble(heads) / 8 * 100 ;
            double tailPercent = Convert.ToDouble(tails) / 8 * 100;
            Console.WriteLine("Percent heads: " + headPercent);
            Console.WriteLine("Percent tails: " + tailPercent);

            Console.ReadLine();
        }
    }
}
