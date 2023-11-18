using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm.Data.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int AgeCategory { get; set; }
        public int Year { get; set; }
        public byte[] CoverImage { get; set; }
        public string Language { get; set; }
        public decimal AverageRating { get; set; }
    }
}
