using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class CityDepartures
    {
        public CityDepartures()
        {
            Tours = new HashSet<Tours>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tours> Tours { get; set; }
    }
}
