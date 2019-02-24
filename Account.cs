using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseWork
{
    class Account : IComparable<Account>
    {
        List<Offer> deposits = new List<Offer>();
        List<Offer> kredits = new List<Offer>();
        List<Account> accounts = new List<Account>();
        Account account;
        string name { get; set; }
        string surname { get; set; }
        string password { get; set; }

        public Account(string name, string surname, string password)
        {
            this.name = name;
            this.surname = surname;
            this.password = password;
        }
        internal void AddDeposit(Deposit dep)
        {
            deposits.Add(dep);
        }
        internal void AddKredit(Kredit kred)
        {
            kredits.Add(kred);
        }
        internal List<Offer> GetDeposits()
        {
            return deposits;
        }
        internal List<Offer> GetKredits()
        {
            return kredits;
        }
        internal bool DoesExist()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts.Contains(account))
                    return true;
            }
            return false;
        }
        internal void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public int CompareTo(Account account)
        {
            if (this.password == account.password)
            {
                return this.name.CompareTo(account.name);
            }
            return account.password.CompareTo(this.password);
        }
    }
}
