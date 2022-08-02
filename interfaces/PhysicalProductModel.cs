using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_namespace
{
    public class PhysicalProductModel
    {
        public string Title { get; set; }
        public bool HasOderBeenCompleted { get; private set; }
        public void ShipItem(CustomerModel customer)
        {
            if(HasOderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} in {customer.City}");
                HasOderBeenCompleted = true;
            }
        }
    }
}
