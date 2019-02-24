using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseWork
{
    class Kredit : Offer
    {
        public Kredit(int amount, int percent, string currency) : base(amount, percent, currency) { }
        public Kredit() { }

        List<Offer> kredits = new List<Offer>();

        public double findDebt(double debt)
        {
            debt = DoubleAmount() / 100 * Percent() + DoubleAmount();
            return debt;
        }
    }
}
