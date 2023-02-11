using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VipApartaments.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Booking = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string PaymentMethod { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
