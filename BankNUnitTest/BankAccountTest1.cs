using Bank;

namespace BankNUnitTest
{
    public class BankAccountTest1
    {
        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Add(500);

            //ASSERT
            Assert.That(account.Balance, Is.EqualTo(1500));
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Withdraw(500);

            //ASSERT
            Assert.That(account.Balance, Is.EqualTo(500));
        }

        [Test]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            //ARRANGE
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            //ACT
            account.TransferFundsTo(otherAccount, 500);

            //ASSERT
            Assert.That(account.Balance, Is.EqualTo(500));
            Assert.That(otherAccount.Balance, Is.EqualTo(500));
        }
    }
} 
