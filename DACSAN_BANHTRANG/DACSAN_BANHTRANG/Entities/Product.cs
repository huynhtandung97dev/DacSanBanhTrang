using System;
using System.Collections.Generic;

#nullable disable

namespace DACSAN_BANHTRANG.Entities
{
    public partial class Product
    {
        public long Id { get; set; }
        public string ProcductName { get; set; }
        public int? Price { get; set; }
        public bool? Status { get; set; }
        public string ImageUrl { get; set; }
        public long? IdCategory { get; set; }
    }
}
