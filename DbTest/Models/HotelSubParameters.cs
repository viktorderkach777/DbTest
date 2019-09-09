using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class HotelSubParameters
    {
        public string Id { get; set; }
        public string HotelParameterId { get; set; }
        public string Name { get; set; }
        public bool? IsFree { get; set; }

        public virtual HotelParameters HotelParameter { get; set; }
    }
}
