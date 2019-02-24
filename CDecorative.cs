using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class CDecorative : Cosmetics
    {
        private int term = 4;
        private int exNum = 40;
        private int waitNum = 10;

        public int Term { get { return term; } }
        public int WaitNum { get { return exNum; } }
        public int ExNum { get { return waitNum; } }

        public CDecorative(string name, int price, int quantity, int deliveryTime, int dayNum) : base(name, price, quantity, deliveryTime, dayNum)
        { }

        public CDecorative() { }

        static List<Cosmetics> decorative = new List<Cosmetics>();

        public override void addNew(Cosmetics cosmetics)
        {
            decorative.Add(cosmetics);
        }

        public static List<Cosmetics> getList()
        {
            return decorative;
        }
    }
}