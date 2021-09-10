using System.Collections.Generic;

namespace TechWow.Store.Repositories.EntityFramework.Models
{
    public class OrderEntity : EntityBase
    {
        public virtual CustomerEntity Customer { get; set; }
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
