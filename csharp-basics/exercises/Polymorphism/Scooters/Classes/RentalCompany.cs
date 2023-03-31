using System;
using Scooters.Classes;
using Scooters.Exeptions;
using Scooters.Interfaces;

namespace Scooters
{
	public class RentalCompany : IRentalCompany
	{
        private readonly IScooterService _scooterService;
        private readonly IRentalArchive _archive;
        public string Name { get; }

        public RentalCompany(string name, IScooterService service, IRentalArchive archive)
		{
            Name = name;
            _scooterService = service;
            _archive = archive;
		}

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal income = 0m;
            if (includeNotCompletedRentals)
            {
                foreach (var record in _archive.ActiveRecords)
                {
                    if (year == null)
                    {
                        var incomOnthisMoment = CauculatePrice(record, DateTime.Now);
                        income += incomOnthisMoment;
                    }
                    else if (year == record.StartRent.Year)
                    {
                        var incomOnthisMoment = CauculatePrice(record, DateTime.Now);
                        income += incomOnthisMoment;
                    }
                }
            }

            foreach (var record in _archive.AllRecords)
            {
                if (year == null)
                {
                    income += record.Cost;
                }
                else if (year == record.EndRent.Year)
                {
                    income += record.Cost;
                }
            }
            return income;
        }

        public decimal EndRent(string id)
        {
            var endDate = DateTime.Now;
            var scooter = _scooterService.GetScooterById(id);
            var rentedScooter = _archive.ActiveRecords.FirstOrDefault(x => x.Id == id);

            if (rentedScooter == null)
            {
                throw new ScooterNotRentedExeption();
            }
            else if (scooter == null)
            {
                throw new NoScooterExeption();
            }

            scooter.IsRented = false;
            rentedScooter.EndRent = endDate;

            var price = CauculatePrice(rentedScooter, endDate);
            rentedScooter.Cost = price;

            return price;
        }

        public void StartRent(string id)
        {
            var startRent = DateTime.Now;
            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new NoScooterExeption();
            }
            else if (scooter.IsRented == true)
            {
                throw new ScooterRentedExeption();
            }
            else
            {
                scooter.IsRented = true;
                var record = new RentalRecord(scooter.Id, scooter.PricePerMinute, startRent);
                _archive.AddToActive(record);
            }
        }

        public decimal CauculatePrice(IRentalRecord record, DateTime endDate)
        {
            var maxPricePerDay = 20.00m;

            var rentalPeriod = endDate - record.StartRent;
            var totalDays = (int)rentalPeriod.TotalDays;
            var remainingMinutes = (int)rentalPeriod.TotalMinutes % 1440;

            var totalCost = maxPricePerDay * totalDays;

            while (remainingMinutes > 0)
            {
                if (totalCost + record.PricePerMinute > maxPricePerDay)
                {
                    break;
                }
                totalCost += record.PricePerMinute;
                remainingMinutes--;
            }

            return totalCost;
        }
    }
}

