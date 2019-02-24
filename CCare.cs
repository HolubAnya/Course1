using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class CCare : Cosmetics, ISlowlyEnding
    {
        private int term = 3;
        private int exNum = 20;
        private int waitNum = 14;

        public int Term { get { return term; } }
        public int WaitNum { get { return exNum; } }
        public int ExNum { get { return waitNum; } }

        public CCare(string name, int price, int quantity, int deliveryTime, int dayNum) : base(name, price, quantity, deliveryTime, dayNum)
        { }

        public CCare()
        { }

        static List<Cosmetics> care = new List<Cosmetics>();

        public override void addNew(Cosmetics cosmetics)
        {
            care.Add(cosmetics);
        }

        public static List<Cosmetics> getList()
        {
            return CCare.care;
        }

        public void UseFaster(Cosmetics product)
        {
            foreach (Cosmetics item in exCosmetics)
            {
                if (product == item)
                {
                    sale(item, 100);
                }
            }
        }

    }
}