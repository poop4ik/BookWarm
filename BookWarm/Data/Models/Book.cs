using System.Drawing;


namespace BookWarm.Data.Models

{
    public class Book
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public int AgeCategory { get; set; }
        public int Year { get; set; }
        public byte[] CoverImage { get; set; }
        public Image CoverImageObject { get; set; }
        public string Language { get; set; }
        public decimal AverageRating { get; set; }
    }
}
