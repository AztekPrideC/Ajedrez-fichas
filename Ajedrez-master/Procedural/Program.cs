using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedural
{
    class Program
    {
        static void Main(string[] args)
        {
Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

//Console.Clear();
string[] peon = new string[4]{
               "#()#",
               "#/\\#",
               "(  )",
               "/__\\"
            };


            string negro = "#";
            string blanco = " ";

            for (int linea = 0; linea < 4; linea++)
            {
                Console.WriteLine(peon[linea]);
            }
            Console.Read();
        }
    }
}
