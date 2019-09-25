using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class User : BaseEntity
    {
        public DateTimeOffset BirthDate { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public byte[] Salt { get; set; }
        public byte[] SaltedAndHashedPassword { get; set; }
    }
}