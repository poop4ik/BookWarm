using System.Security.Cryptography.X509Certificates;

namespace BookWarm.Data.Models
{
    public class BookGenre
    {
        public int BookID { get; set; }
        public int GenreID { get; set; }
        public int GenreBookRelationID { get; set; }
        public string GenreName { get; set; }
    }
}
