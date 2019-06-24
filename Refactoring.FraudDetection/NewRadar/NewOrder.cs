using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    public class NewOrder
    {
        public int OrderId { get; set; }

        public int DealId { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string CreditCard { get; set; }

        public bool Equals(NewOrder other)
        {
            if (other.DealId == DealId
                && other.Email == Email)
            {
                return true;
            }

            if (other.DealId == this.DealId
                && other.State == this.State
                && other.ZipCode == this.ZipCode
                && other.Street == this.Street
                && other.City == this.City)
            {
                return true;
            }
            return false;

        }
    }
}