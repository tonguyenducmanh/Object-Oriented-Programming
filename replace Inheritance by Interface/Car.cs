namespace replace_Inheritance_by_Interface
{
    public class Car : LandVehicle, IRental
        {
            public int RentalId { get; set; }
            public string CurrentRenter { get; set; }
            public decimal PricePerDay { get; set; }
        }
}