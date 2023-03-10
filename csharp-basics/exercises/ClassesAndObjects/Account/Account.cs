namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            this._name = v1;
            this._money = v2;
        }

        public double Withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public void Deposit(double i)
        {
            _money += i;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public static void Transfer(Account from, Account to, double summ)
        {
            var amount = from.Withdrawal(summ);
            to.Deposit(amount);
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
