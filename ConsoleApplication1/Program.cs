using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your age.");

            //int userAge = int.Parse(Console.ReadLine());

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                }

            //Had to change userAge to line for CodeEval

            if (line >= 0 && line <= 2)
            {
                System.Console.WriteLine("Still in Mama's Arms");
            }
            else if (line >= 3 && line <= 4)//May also be written (line == 3 || line == 4)
            {
                System.Console.WriteLine("Preschool Maniac");
            }
            else if (line >= 5 && line <= 11)
            {
                System.Console.WriteLine("Elementary School");
            } 
            else if (line >= 12 && line <= 14)
            {
                System.Console.WriteLine("Middle School");
            }
            else if (line >= 15 && line <= 18)
            {
                System.Console.WriteLine("High School");
            }
            else if (line >= 19 && line <= 22)
            {
                System.Console.WriteLine("College");
            }
            else if (line >= 23 && line <= 65)
            {
                System.Console.WriteLine("Working for the Man");
            }
            else if (line >= 66 && line <= 100)
            {
                System.Console.WriteLine("The Golden Years");
            }
            else if (line <= 0 && line >= 100)
            {
                System.Console.WriteLine("This program is for humans.");
            }
        }
    }
}
