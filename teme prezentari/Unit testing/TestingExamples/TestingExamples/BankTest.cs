using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    internal class BankTest
    {
        public class Account
        {
            private decimal balance;
            private decimal minimumBalance = 10m;

            public void Deposit(decimal amount)
            {
                balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                balance -= amount;
            }

            public void TransferFunds(Account destination, decimal amount)
            {
                if (balance - amount < minimumBalance)
                    throw new InsufficientFundsException();

                destination.Deposit(amount);

                Withdraw(amount);

                throw new NotImplementedException();
            }

            public void DepositWithInterest(decimal amount)
            {
                balance += amount * 1.2m;
            }

            public decimal Balance
            {
                get { return balance; }
            }

            public decimal MinimumBalance
            {
                get { return minimumBalance; }
            }
        }

        public class InsufficientFundsException : ApplicationException
        {
        }

        [TestFixture]
        public class AccountTest
        {
            Account source;
            Account destination;

            [SetUp]
            public void Init()
            {
                source = new Account();
                source.Deposit(200m);

                destination = new Account();
                destination.Deposit(150m);
            }

            [Test]
            public void TransferFunds()
            {
                source.TransferFunds(destination, 100m);

                Assert.That(destination.Balance, Is.EqualTo(250m));
                Assert.That(source.Balance, Is.EqualTo(100m));
            }

            [Test]
            public void TransferWithInsufficientFunds()
            {
                Assert.Throws<InsufficientFundsException>(() => source.TransferFunds(destination, 300m));
            }

            [Test]
            public void DepositWithInterest()
            {
                var initialBalance = source.Balance;

                source.DepositWithInterest(100m);

                Assert.That(source.Balance, Is.EqualTo(initialBalance + 120));
            }

            [Test]
            [Ignore("Decide how to implement transaction management")]
            public void TransferWithInsufficientFundsAtomicity()
            {
                try
                {
                    source.TransferFunds(destination, 300m);
                }
                catch (InsufficientFundsException expected)
                {
                }

                Assert.AreEqual(200m, source.Balance);
                Assert.AreEqual(150m, destination.Balance);
            }
        }
    }
}
