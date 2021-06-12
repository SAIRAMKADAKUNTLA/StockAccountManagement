using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockData
{
    public class StockDetails
    {
        public void GetStock()
        {
            int valueOfStock ;
            int totalValueOfStock = 0;
            var json = File.ReadAllText(@"E:\BridgeLabz\Stock_Account_Management\StockAccountManagement\StockData\StockData\Stact.json");
            var jObject = JObject.Parse(json);
            var stockarray = (JArray)jObject["Stack_Account"];
            if(jObject != null)
            {
                Console.WriteLine("--------Stock Data---------");
                Console.WriteLine();
                Console.WriteLine("StockName   NumberofShares   SharePrice   ValueofStock");
                foreach(var iteam in stockarray)
                {
                    valueOfStock = TotalValue(iteam["NumOfShares"], iteam["SharePrice"]);
                    totalValueOfStock += valueOfStock;
                    Console.WriteLine(iteam["StockName"] + "    " + iteam["NumOfShares"] + "      " + iteam["SharePrice"] + "     " + valueOfStock);
                    Console.WriteLine("total value"+ totalValueOfStock);
                }
            }
        }
        public int TotalValue(JToken NumOfShares, JToken SharePrice)
        {
            int shares = NumOfShares.ToObject<int>();
            int price = SharePrice.ToObject<int>();
            int valueOfStock = 0;

            valueOfStock = shares * price;
            
            return valueOfStock;

        }
    }
}
