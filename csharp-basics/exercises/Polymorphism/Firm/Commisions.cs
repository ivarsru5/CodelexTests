using System;
namespace Firm
{
	public class Commisions: Hourly
	{
		private double totalSales;
		private double commisionRate;

		public Commisions(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commison) :
			base(eName, eAddress, ePhone, socSecNumber, rate)
		{
			commisionRate = commison;
		}

        public void AddSales(double amount)
        {
			double totalWithCommision = (Pay() * commisionRate);
			totalSales += totalWithCommision;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent sales: " + totalSales;
            return result;
        }
    }
}

