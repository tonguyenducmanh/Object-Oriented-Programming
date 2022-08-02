namespace interfaces_namespace
{
    public class Program
    {
        public static void Main()
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = new CustomerModel();
            foreach (PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel()
            {
                FirstName = "manh",
                LastName = "duc",
                City = "hanoi",
                EmailAddress = "ducmanh14032000@gmail.com",
                PhoneNumber = "0981071321"
            };
        }
        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new();
            return output;
        }
    }
}