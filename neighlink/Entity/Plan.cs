using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Plan : BaseEntity
    {
        public virtual ICollection<Condominium> Condominiums { get; set; }
        public string Description { get; set; }
        public int NumberOfHomes { get; set; }
        public PlanType Type { get; set; }
    }
}
