using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class Building : BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int NumberOfHomes { get; set; }
    }
}
