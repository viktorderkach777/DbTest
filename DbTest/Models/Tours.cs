using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class Tours
    {
        public Tours()
        {
            Orders = new HashSet<Orders>();
        }

        public string Id { get; set; }
        public string HotelId { get; set; }
        public decimal? Price { get; set; }
        public int? DaysCount { get; set; }
        public DateTime? FromData { get; set; }
        public string CityDepartureId { get; set; }

        public virtual CityDepartures CityDeparture { get; set; }
        public virtual Hotels Hotel { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
