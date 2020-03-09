using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MambaMentalityAPI.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteText { get; set; }
        public string PoV { get; set; }
    }
}
