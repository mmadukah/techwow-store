namespace TechWow.Store.Repositories.EntityFramework.Models
{
    public class OrderItemEntity : EntityBase
    {
        public virtual ProductEntity Product { get; set; }
    }
}
