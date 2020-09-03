using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSum.BuisnessLogic.Interface
{
    public interface IParser
    {
        int ProcessTheNodes(int rows, int[,] tableHolder);
        bool IsAllowedNumber(int number);
         void ShowOutput(int rows, int[,] tableHolder);
    }
}
