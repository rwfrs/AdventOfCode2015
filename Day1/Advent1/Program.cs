using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDirections = System.IO.File.ReadAllText(@"C:\Users\rwfrs\Documents\Projects\Advent2015input\input.txt");

            int floorUp = 0;
            int floorDown = 0;
            int totalFloorMoves = 0;
            bool firstChar = false;
            int position = 0;
            int charPositionBasement = 0;

            foreach (char directions in inputDirections)
            {
                totalFloorMoves++;
               
                if (directions.ToString() == "(")
                {
                    floorUp++;
                }
                else if (directions.ToString() == ")")
                {
                    floorDown++;
                }

                position = floorUp - floorDown;

                if(position == -1 && firstChar == false)
                {
                    charPositionBasement = totalFloorMoves;
                    firstChar = true;
                } 
            }

            Console.WriteLine("To what floor do the instructions take Santa?");
            Console.WriteLine("--- Part One --- Answer: " + (floorUp - floorDown));
            Console.WriteLine();
            Console.WriteLine("What is the position of the character that causes Santa to first enter the basement?");
            Console.WriteLine("--- Part Two --- Answer: " + charPositionBasement);

            Console.ReadLine();
        }
    }
}
