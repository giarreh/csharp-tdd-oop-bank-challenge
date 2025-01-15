﻿using Boolean.CSharp.Main.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Interface
{
    public interface IUser
    {
        public string CreateSavingsAccount(string name);
        public string CreateCurrentAccount(string name);

        public void GenerateReport();
        public void Deposit(IAccount account, double amount);
        public void Withdraw(IAccount account, double amount);
    }
}