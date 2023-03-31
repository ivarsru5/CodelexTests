using System;
using Scooters.Exeptions;

namespace Scooters
{
	public class ScooterService : IScooterService
	{
        private readonly List<Scooter> _scooters;

		public ScooterService(List<Scooter> scooters)
		{
            _scooters = scooters;
		}

        public void AddScooter(string id, decimal pricePerMinute)
        {
            var check = _scooters.SingleOrDefault(x => x.Id == id);

            if (string.IsNullOrEmpty(id))
            {
                throw new NoScooterIdExeption();
            }
            else if(pricePerMinute <= 0)
            {
                throw new InvalidPriceExeption();
            }
            else if (check != null)
            {
                throw new ScooterExistsExeption();
            }

            var scooter = new Scooter(id, pricePerMinute);
            _scooters.Add(scooter);
        }

        public Scooter GetScooterById(string scooterId)
        {
            if (string.IsNullOrEmpty(scooterId))
            {
                throw new NoScooterIdExeption();
            }

            var scooter = _scooters.SingleOrDefault(x => x.Id == scooterId);

            if (scooter != null)
            {
                return scooter;
            }
            else
            {
                throw new NoScooterIdExeption();
            }
        }

        public IList<Scooter> GetScooters()
        {
            return _scooters.ToList();
        }

        public void RemoveScooter(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new NoScooterIdExeption();
            }

            var scooter = _scooters.SingleOrDefault(x => x.Id == id);

            if (scooter != null)
            {
                _scooters.Remove(scooter);
                return;
            }

            throw new ScooterRentedExeption();
        }
    }
}

