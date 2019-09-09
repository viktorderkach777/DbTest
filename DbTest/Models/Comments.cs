using System;
using System.Collections.Generic;

namespace DbTest.Models
{
    public partial class Comments
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string HotelId { get; set; }
        public DateTime CreatingDate { get; set; }
        public string Message { get; set; }
        public string HotelsId { get; set; }

        public virtual Hotels Hotels { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
