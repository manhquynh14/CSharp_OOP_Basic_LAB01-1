﻿using System;
using System.Collections.Generic;

namespace AP_Lab01_problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount();
            firstAccount.Id = 1;
            firstAccount.Balance = 100;

            BankAccount secondAccount = new BankAccount();
            secondAccount.Id = 1;
            secondAccount.Balance = 200;

            List<BankAccount> accounts = new List<BankAccount> { firstAccount, secondAccount };
            Person person = new Person("Ivan", 20, accounts);

            Console.WriteLine($"Name: {person.Name}, age: {person.Age}, total balance: {person.GetBalance():F2}");
        }
    }
}
