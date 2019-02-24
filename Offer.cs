using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseWork
{
    [Serializable()]
    abstract class Offer
    {
        public string currency { get; set; }
        public int amount { get; set; }
        public int percent { get; set; }


        public Offer(int amount, int percent, string currency)
        {
            this.amount = amount;
            this.currency = currency;
            this.percent = percent;
          
        }
        public Offer() { }

        public string GetCurrency()
        {
            return currency;
        }
        public string Amount()
        {
            return amount.ToString();
        }
        public int Percent()
        {
            return percent;
        }
        public string Show()
        {
            return amount.ToString() + currency.ToString() + percent.ToString() + "%";
        }
        public double DoubleAmount()
        {
            return Convert.ToDouble(amount);
        }
    }
}
