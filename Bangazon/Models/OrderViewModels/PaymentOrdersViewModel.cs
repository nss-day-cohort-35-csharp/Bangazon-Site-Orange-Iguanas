using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.OrderViewModels
{
    public class PaymentOrdersViewModel
    {
        public ICollection<OrderProduct> OrderProducts { get; set; }

        public ICollection<PaymentType> PaymentTypes { get; set; }
    }
}
