using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options.Domain.Entities
{
    public class WatchItem
    {
        public string Symbol { get; set; }
        public double LowValue { get; set; }
        public double HighValue { get; set; }
        public string ExpDate { get; set; }
    }
}
