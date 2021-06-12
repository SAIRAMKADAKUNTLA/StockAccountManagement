using System;

namespace StockData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stock account management");
            StockDetails stockDetails = new StockDetails();
            stockDetails.GetStock();
        }
    }
}
