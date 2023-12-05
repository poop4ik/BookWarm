namespace BookWarm.Data.Models
{
    public class UserStatistics
    {
        public int StatisticID { get; set; }
        public int UserID { get; set; }
        public int TotalViews { get; set; }
        public int TotalReads { get; set; }

    }
}
