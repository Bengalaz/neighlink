using Entity.Contracts;
using System.Collections.Generic;

namespace Entity
{
    public class Role : BaseEntity
    {
        public string Description { get; set; }
        public UserRole Type { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
