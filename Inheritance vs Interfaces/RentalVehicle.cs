
namespace Inheritance
{
    public class RentalVehicle
    {
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public int NumberOfPassengers { get; set; }
        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}