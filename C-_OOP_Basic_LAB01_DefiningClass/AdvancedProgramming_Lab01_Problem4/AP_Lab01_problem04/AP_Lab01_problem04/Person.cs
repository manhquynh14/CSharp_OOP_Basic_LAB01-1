﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AP_Lab01_problem04
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
            : this(name, age, new List<BankAccount>())
        {
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public List<BankAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal GetBalance()
        {
            decimal balance = this.accounts.Sum(a => a.Balance);
            return balance;
        }
    }
}
