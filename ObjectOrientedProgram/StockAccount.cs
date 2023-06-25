using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class StockAccount
    {
        public List<StockReport> stockReport;
    }
    public class StockReport
    {
        public string stockName;
        public int numberOfShare;
        public int sharePrice;
    }
}
    

