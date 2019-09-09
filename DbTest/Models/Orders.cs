using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class Orders
    {
        public string Id { get; set; }
        public string TourId { get; set; }
        public string UserId { get; set; }

        public virtual Tours Tour { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
