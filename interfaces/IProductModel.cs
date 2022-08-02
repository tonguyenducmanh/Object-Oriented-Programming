using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_namespace
{
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOderBeenCompleted { get;}
        void ShipItem(CustomerModel customer);
    }
}
