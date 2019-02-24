using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public abstract class Cosmetics 
    {
        public string name { get; set; }

        protected int quantity { get; set; }

        protected int deliveryTime { get; set; }

        protected int price { get; set; }

        protected int dayNum { get; set; }

        protected static List<Cosmetics> exCosmetics = new List<Cosmetics>();

        public Cosmetics(string name, int price, int quantity, int deliveryTime, int dayNum)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.deliveryTime = deliveryTime;
            this.dayNum = dayNum;
        }

        public Cosmetics() { }

        public void findNecessary(List<Cosmetics> list, int term, int number, int waitNum)
        {
            foreach (Cosmetics cosm in list)
            {
                if (dayNum <= term || quantity < number || deliveryTime > waitNum)
                {
                    exCosmetics.Add(cosm);
                }
            }
        }

        public static List<Cosmetics> getExCosmetics()
        {
            return exCosmetics;
        }

        public void deleteOld(List<Cosmetics> list)
        {
            foreach (Cosmetics cosm in list)
            {
                if (dayNum <= 1)
                {
                    list.Remove(cosm);
                }
            }
        }

        public abstract void addNew(Cosmetics cosmetics);

        public string show()
        {
            return name + " " + price + "$ " + quantity + " items";
        }

        public static bool ifExist(List<Cosmetics> list, string name)
        {
            foreach (Cosmetics item in list)
            {
                if (item.name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void sale(Cosmetics cosmetics, int amount)
        {
            cosmetics.price -= amount;
        }
    }
}