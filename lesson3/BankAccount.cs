using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class BankAccount
    {
        private long _accountNum;
        private int _balance;
        private string _type;

        public long AccountNum
        {
            get { return _accountNum; }
        }

        public int Balance
        {
            get { return _balance; }
        }

        public string Type
        {
            get { return _type; }
        }

        public BankAccount(long accountNum, int balance, string type)
        {
            _accountNum = accountNum;
            _balance = balance;
            _type = type;
        }

    }
}