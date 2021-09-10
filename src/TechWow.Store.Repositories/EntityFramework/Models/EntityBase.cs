using System;

namespace TechWow.Store.Repositories.EntityFramework.Models
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
