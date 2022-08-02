namespace replace_Inheritance_by_Interface
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}