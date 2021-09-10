using System.Collections.Generic;

namespace TechWow.Store.Web.Models
{
    public class OrderModel : ModelBase
    {
        public CustomerModel Customer { get; set; }
        public ICollection<OrderItemModel> OrderItems { get; set; }
    }
}
