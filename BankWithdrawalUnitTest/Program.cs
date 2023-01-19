using NUnit.Framework;
using SampleNunitProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithdrawalUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SampleNunit myNunit = new SampleNunit();
            myNunit.MoneyWithdrawal();


        }
    }
}
