using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public decimal Rate { get; set; }
    }
}
