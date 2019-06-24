using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    public class OrderFactory : Singleton<OrderFactory>
    {
        // private static OrderFactory instance;
        /*private OrderFactory() { }*/
        /*public static OrderFactory GetInstance()
        {
            if (instance == null)
                instance = new OrderFactory();
            return instance;
        }*/

        public NewOrder NewOrder(string sourceText)
        {
            NewOrder newOrder = new NewOrder();
            var items = sourceText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            newOrder.OrderId = int.Parse(items[0]);
            newOrder.DealId = int.Parse(items[1]);
            newOrder.Email = items[2].ToLower();
            newOrder.Street = items[3].ToLower();
            newOrder.City = items[4].ToLower();
            newOrder.State = items[5].ToLower();
            newOrder.ZipCode = items[6];
            newOrder.CreditCard = items[7];
            return newOrder;
        }
    }
}
