using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Payvision.CodeChallenge.Refactoring.FraudDetection.FraudRadar;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    internal class FileReader
    {
        public string filePath;
        public FileReader(string filePath) 
        {
            this.filePath = filePath;
        }
        public List<NewOrder> GetOrders()
        {
            var orders = new List<NewOrder>();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                NewOrder order = OrderFactory.GetInstance.NewOrder(line);
                
                orders.Add(order);
            }
            return orders;
        }
    }
}
