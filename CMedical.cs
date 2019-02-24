using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class CMedical : Cosmetics, ISlowlyEnding
    {
        private int term = 8;
        private int exNum = 10;
        private int waitNum = 30;

        public int Term { get { return term; } }
        public int WaitNum { get { return exNum; } }
        public int ExNum { get { return waitNum; } }

        public CMedical(string name, int price, int quantity, int deliveryTime, int dayNum) : base(name, price, quantity, deliveryTime, dayNum)
        { }

        public CMedical() { }

        static List<Cosmetics> medical = new List<Cosmetics>();

        public override void addNew(Cosmetics cosmetics)
        {
            medical.Add(cosmetics);
        }

        public static List<Cosmetics> getList()
        {
            return medical;
        }

        public void UseFaster(Cosmetics product)
        {
            foreach (Cosmetics item in exCosmetics)
            {
                if (product == item)
                {
                    deleteOld(medical);
                }
            }
        }
    }
}