using System;
namespace BankAccount
{
	public class Account
	{
		private string _userName;
		private string _holder;
		private double _balance;

		public Account(string userName, string holder, double balance)
		{
			this._userName = userName;
			this._holder = holder;
			this._balance = balance;
		}

		public string GetUser()
		{
            return $"{_holder}, ${_balance.ToString("#.##")}";
        }
	}
}

