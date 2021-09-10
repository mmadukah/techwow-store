using System.Collections.Generic;

namespace TechWow.Store.Core.Models
{
    public class Order : ModelBase
    {
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
