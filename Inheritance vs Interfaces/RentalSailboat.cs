
namespace Inheritance
{
    public class RentalSailboat: RentalVehicle
    {
        public override void StartEngine()
        {
            throw new Exception("I don't have an engine to start");
        }
        public override void StopEngine()
        {
            throw new Exception("I don't have an engine to stop");
        }
    }
}