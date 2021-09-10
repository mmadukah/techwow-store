using System;

namespace TechWow.Store.Core.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
