using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShard
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabit = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.Write("Enter random letter:");
            char val1 = char.Parse(Console.ReadLine().ToUpper());
            //Console.Write(val1);

            printOutput(alphabit, val1);
            Console.ReadKey();
        }

        public static void printOutput(string param, char val)
        {
            //ABCDEFGHIJKLMNOPQRSTUVWXYZ

            string alp = param.Split(val)[0];
            int sLenght = alp.Length;        
            
            /// A shaped
            for (int i = 0; i < sLenght; i++) 
            {
                string sPrint = string.Empty;
                for (int j = sLenght; j >= i; j--)
                {
                    sPrint += " ";//  Console.Write("-");
                }
                sPrint += i != 0 ? param.Substring(i, 1) : string.Empty;
                for (int k = 0; k < i; k++)
                {
                    sPrint += " ";
                }
                for (int l = 0; l <= i; l++)
                {
                    sPrint += " ";
                }
                sPrint += param.Substring(i, 1);
                Console.WriteLine(sPrint);                
            }

            //V shaped
            for (int i = sLenght; i >= 0; i--)
            {
                string sPrint = string.Empty;
                for (int j = sLenght; j >= i; j--)
                {
                    sPrint += " ";
                }
                sPrint += param.Substring(i, 1);
                for (int k = 0; k < i; k++)
                {
                    sPrint += " ";
                }
                for (int l = 0; l <= i; l++)
                {
                    sPrint += " ";
                }
                sPrint += i != 0 ? param.Substring(i, 1) : string.Empty;
                Console.WriteLine(sPrint);
            }
        }
    }
}
