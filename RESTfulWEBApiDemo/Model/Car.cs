namespace RESTfulWEBApiDemo.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public int KilometersDriven { get; set; }
        public Location? Location { get; set; }

        public Car(int id, string brand, string fuelType, int passengerCapacity, int kilometersDriven, Location location)
        {            
            Id = id;
            Brand = brand;
            FuelType = fuelType;
            PassengerCapacity = passengerCapacity;
            KilometersDriven = kilometersDriven;
            Location = location;
        }
    }
}
