namespace TechWow.Store.Repositories.EntityFramework.Models
{
    public class CustomerEntity : EntityBase
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
