using ObjectOrientedProgram;
using System;
using System.IO;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to object oriented program");

            Console.WriteLine("==========||==========");

            string path2 = "D:\\RFP281 Project\\ObjectOrientedProgram";
            ReadTheData read = new ReadTheData();

            StockAccount account = read.Read2(path2);

            Console.WriteLine("==========|Stock Report|==========");
            for (int x = 0; x < account.stockReport.Count; x++)
            {
                Console.WriteLine(account.stockReport[x].stockName);
                Console.WriteLine(account.stockReport[x].numberOfShare);
                Console.WriteLine(account.stockReport[x].sharePrice);
                int totalstockprice = account.stockReport[x].numberOfShare * account.stockReport[x].sharePrice;
                double stockprice = account.stockReport[x].sharePrice / account.stockReport[x].numberOfShare;
                Console.WriteLine($"The value of each stock is {stockprice}");
                Console.WriteLine("Total value of stock of {0} is {1}. \n", account.stockReport[x].stockName, totalstockprice);
            }
        }
    }
}