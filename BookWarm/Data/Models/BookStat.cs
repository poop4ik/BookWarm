using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm.Data.Models
{
    public class BookStat
    {
        public int BookID { get; set; }
        public int ReadID { get; set; }
        public int ReadsCount { get; set; }
        public int ViewID { get; set; }
        public int ViewCount { get; set; }
    }
}
