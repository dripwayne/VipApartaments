using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VipApartaments.Models
{
    public partial class Details
    {
        public int Id { get; set; }
        public int IdBook { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public virtual Booking IdBookNavigation { get; set; }
    }
}
