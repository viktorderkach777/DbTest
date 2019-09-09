using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Regions = new HashSet<Regions>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Regions> Regions { get; set; }
    }
}
