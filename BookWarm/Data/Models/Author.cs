using System.Drawing;
using BookWarm.Data.Models;


namespace BookWarm.Data.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public int RelationID { get; set; }
        public int BookID { get; set; }
        public string AuthorName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public byte[] AuthorPhoto { get; set; }
        public Image AuthorPhotoObject { get; set; }

    }
}
