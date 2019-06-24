using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Payvision.CodeChallenge.Refactoring.FraudDetection.FraudRadar;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    public class FraudChecker : Singleton<FraudChecker>
    {

        public List<NewFraudResult> Check(List<NewOrder> orders)
        {

            var fraudResults = new List<NewFraudResult>();

            for (int i = 0; i < orders.Count; i++)
            {
                var current = orders[i];

                for (int j = i + 1; j < orders.Count; j++)
                {
                    if (current.Equals(orders[j])
                        && current.CreditCard != orders[j].CreditCard)
                    {
                        fraudResults.Add(new NewFraudResult { IsFraudulent = true, OrderId = orders[j].OrderId });
                    }
                }
            }
            return fraudResults;
        }
    }
}
