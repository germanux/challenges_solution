using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    public class NewFraudRadar : FraudRadar
    {
        new public IEnumerable<NewFraudResult> Check(string filePath)
        {
            var orders = new List<NewOrder>();
            FileReader fr = new FileReader(filePath);
            orders = fr.GetOrders();
            orders = OrderNormalizer.GetInstance.Normalize(orders);
            var fraudResults = FraudChecker.GetInstance.Check(orders);
            return fraudResults;
        }
    }
}