using MaximumSum.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input
            var input = GetInput();

            string[] arrayOfRowsByNewlines = input.Split('\n');
            if(!isAlphaPresent(input.Replace("\r\n", "")))
            {
                var tableHolder = ConvertTheTriangleIntoTable(arrayOfRowsByNewlines);
                if (tableHolder.Length > 0)
                {
                    GatewayClass obj = new GatewayClass(new TMaxSummOddEven());//dependency injection
                    obj.ShowOutput(arrayOfRowsByNewlines.Length, tableHolder);
                }
                else
                {
                    Console.WriteLine("The Input is not valid triangle !!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Alphabet is not allowed in triangle !!");
                Console.ReadKey();
            }

        }
        private static string GetInput()
        {

            const string input = @"     215 
                                        192 124
                                        117 269 442
                                        218 836 347 235
                                        320 805 522 417 345
                                        229 601 728 835 133 124
                                        248 202 277 433 207 263 257
                                        359 464 504 528 516 716 871 182
                                        461 441 426 656 863 560 380 171 923
                                        381 348 573 533 448 632 387 176 975 449
                                        223 711 445 645 245 543 931 532 937 541 444
                                        330 131 333 928 376 733 017 778 839 168 197 197
                                        131 171 522 137 217 224 291 413 528 520 227 229 928
                                        223 626 034 683 839 052 627 310 713 999 629 817 410 121
                                        924 622 911 233 325 139 721 218 253 223 107 233 230 124 233 ";
            return input;
        }
              
        private static int[,] ConvertTheTriangleIntoTable(string[] arrayOfRowsByNewlines)
        {
            int[,] tableHolder = new int[arrayOfRowsByNewlines.Length, arrayOfRowsByNewlines.Length + 1];

            for (int row = 0; row < arrayOfRowsByNewlines.Length; row++)
            {
                var eachCharactersInRow = arrayOfRowsByNewlines[row].Trim().Split(' ');
                //validation for correct triangle
                if ((eachCharactersInRow.Length != row+1))
                {
                    tableHolder = new int[0, 0];
                    break;
                }

                for (int column = 0; column < eachCharactersInRow.Length; column++)
                {
                    int number;
                    int.TryParse(eachCharactersInRow[column], out number);
                    tableHolder[row, column] = number;
                }
            }
            return tableHolder;
        }

        public static Boolean isAlphaPresent(string strToCheck)
        {

            int errorCounter = Regex.Matches(strToCheck, @"[a-zA-Z]").Count;
            return errorCounter>0?true:false;
        }


    }
}
