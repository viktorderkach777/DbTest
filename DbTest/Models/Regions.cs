using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class Regions
    {
        public Regions()
        {
            Hotels = new HashSet<Hotels>();
        }

        public string Id { get; set; }
        public string CountryId { get; set; }
        public string Name { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Hotels> Hotels { get; set; }
    }
}
