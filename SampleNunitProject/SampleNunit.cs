using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNunitProject
{
    //Make sure to intall in your Nuget packages the following:
    //1. NUnit
    //2. NUnit3TestAdapter

    //This example will show how we can test a sample unit of an SUT (system under test). In this project, the SUT will be if a bank account owner withdraws money from his/her bank account 
    public class SampleNunit
    {
        [Test]
        public void MoneyWithdrawal()
        {
            int initialbalance = 1000;
            int amount = 150;//to be used only to verify if test works
            int currentbalance;


            //Arrange - similar to 'Given' approach in Specflow. This
            Console.WriteLine("Helaman's bank account balance\n\n");
            Console.Write("How much are you gonna withdraw today? ");
            //amount = int.Parse(Console.ReadLine()); //To be used only when running locally

            //Act - similar to 'Then' approach in Specflow
            currentbalance = initialbalance - amount;

            Console.WriteLine($"\n\nYour current balance is {currentbalance}.");
            //Console.ReadLine(); //To be used only when running locally
            
            //Assert - similar to 'Then' approach in Specflow
            Assert.True(currentbalance < initialbalance, "Current balance calculation is incorrect!");


        }






    }
}
