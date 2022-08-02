namespace replace_Inheritance_by_Interface
{
   public interface IRental
        {
            public int RentalId { get; set; }
            public string CurrentRenter { get; set; }
            public decimal PricePerDay { get; set; }
        }
}