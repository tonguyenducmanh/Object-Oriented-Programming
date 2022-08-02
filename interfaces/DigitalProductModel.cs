using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_namespace
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOderBeenCompleted { get; private set; }
        public int TotalDownloadLeft { get; private set; } = 5;
        public void ShipItem(CustomerModel customer)
        {
            if (HasOderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
                TotalDownloadLeft -= 1;
                if(TotalDownloadLeft < 1)
                {
                    HasOderBeenCompleted = true;
                    TotalDownloadLeft = 0;
                }
            }
            
        }
    }
}
