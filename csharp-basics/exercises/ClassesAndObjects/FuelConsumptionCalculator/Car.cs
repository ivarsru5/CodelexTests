namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double StartKilometers;
        public double EndKilometers;
        public double Liters;


        public Car(double startOdo, double endOdo, double liters)
        {
            this.StartKilometers = startOdo;
            this.EndKilometers = endOdo;
            this.Liters = liters;
        }

        public double CalculateConsumption()
        {
            var distance = EndKilometers - StartKilometers;
            var distanceBy1Liter = distance / Liters;
            return distanceBy1Liter;
        }

        private double ConsumptionPer100Km()
        {
            var distance = EndKilometers - StartKilometers;
            var consumption = Liters / (distance / 100);
            return consumption;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
        }
    }
}
