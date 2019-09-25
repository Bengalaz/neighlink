using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class Condominium : BaseEntity
    {
        public string Address { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public string SecretCode { get; set; }
    }
}
