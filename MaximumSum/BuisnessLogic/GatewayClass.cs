using MaximumSum.BuisnessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSum.BuisnessLogic
{
    public class GatewayClass
    {
        private IParser _instance;
        public GatewayClass(IParser Instance)
        {
            this._instance = Instance;
        }
        public void ShowOutput(int rows, int[,] tableHolder)
        {
            _instance.ShowOutput(rows, tableHolder);
        }
    }
}
