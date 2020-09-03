using MaximumSum.BuisnessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSum.BuisnessLogic
{
    public class TMaxSummOddEven : IParser
    {
        // Function for finding maximum sum 
        public int ProcessTheNodes(int rows, int[,] tableHolder)
        {
            bool Evenflag = IsAllowedNumber(tableHolder[0, 0]) ? false : true;
            int result = tableHolder[0, 0];
            int j = 0;
            for (int i = 1; i <= rows - 1; i++)
            {
                if (Evenflag == true)
                {
                    if (IsAllowedNumber(tableHolder[i, j]) && IsAllowedNumber(tableHolder[i, j + 1]))
                    {
                        if (tableHolder[i, j] > tableHolder[i, j + 1])
                        {
                            result += tableHolder[i, j];
                        }
                        else
                        {
                            result += tableHolder[i, j + 1];
                            j = j + 1;
                        }

                        Evenflag = false;
                    }
                    else if (IsAllowedNumber(tableHolder[i, j]))
                    {

                        result += (tableHolder[i, j]);
                        Evenflag = false;
                    }
                    else if (IsAllowedNumber(tableHolder[i, j + 1]))
                    {

                        result += (tableHolder[i, j + 1]);
                        j = j + 1;
                        Evenflag = false;
                    }
                }
                else if (Evenflag == false)
                {
                    if (!IsAllowedNumber(tableHolder[i, j]) && !IsAllowedNumber(tableHolder[i, j + 1]))
                    {

                        if (tableHolder[i, j] > tableHolder[i, j + 1])
                        {
                            result += tableHolder[i, j];
                        }
                        else
                        {
                            result += tableHolder[i, j + 1];
                            j = j + 1;
                        }
                        Evenflag = true;
                    }
                    else if (!IsAllowedNumber(tableHolder[i, j]))
                    {

                        result += (tableHolder[i, j]);
                        Evenflag = true;
                    }
                    else if (!IsAllowedNumber(tableHolder[i, j + 1]))
                    {

                        result += (tableHolder[i, j + 1]);
                        j = j + 1;
                        Evenflag = true;
                    }
                }


            }
            return result;
        }
        public  bool IsAllowedNumber(int number)
        {
            //implementing even number check
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowOutput(int rows, int[,] tableHolder)
        {
            Console.WriteLine($"The Maximum Total Sum Of Non-Prime Numbers From Top To Bottom Is:  {ProcessTheNodes(rows, tableHolder)}");
            Console.ReadKey();
        }
    }
}
