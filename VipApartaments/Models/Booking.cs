using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VipApartaments.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Details = new HashSet<Details>();
        }

        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdRoom { get; set; }
        public int IdMethodOfPayment { get; set; }
        public int ToPay { get; set; }
        public bool Pay { get; set; }

        public virtual Clients IdClientNavigation { get; set; }
        public virtual Payment IdMethodOfPaymentNavigation { get; set; }
        public virtual Rooms IdRoomNavigation { get; set; }
        public virtual ICollection<Details> Details { get; set; }
    }
}
