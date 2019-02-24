using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPcourseWork
{
    [Serializable()]
    class Deposit : Offer
    {
        public Deposit(int amount, int percent, string currency) : base(amount, percent, currency)
        {}
        public Deposit() { }
        List<Offer> deposits = new List<Offer>();

        public double CurrentSum(double sum)
        {
            sum = DoubleAmount() / 100 * Percent() + DoubleAmount();
            return sum;
        }
    }
}
