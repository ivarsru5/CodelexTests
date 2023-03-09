using System;
namespace SavingsAccount
{
	public class SavingsAccount
	{
		private double _savingsAmount;
		public double totalInInterests;
		public double totalWidraw;
		public double totalDeposit;

		public SavingsAccount(double savings)
		{
			this._savingsAmount = savings;
		}

        public void Widraw(double amount)
        {
			 this._savingsAmount -= amount;
			totalWidraw += amount;
        }

		public void AddMoney(double amount)
		{
			this._savingsAmount += amount;
			totalDeposit += amount;

        }

		public void Interest(double interestRate)
		{
			var percent = interestRate / 100;
			var interest = _savingsAmount * percent;
			var eachMonth = interest / 12;
			totalInInterests += eachMonth;
			_savingsAmount += eachMonth;
		}

		public double GetBalance()
		{
			return _savingsAmount;
		}
    }
}

