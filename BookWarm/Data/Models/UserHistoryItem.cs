using System;

public class UserHistoryItem
{
    public int BookID { get; set; }
    public DateTime ViewDate { get; set; }

    public UserHistoryItem(int bookID, DateTime viewDate)
    {
        BookID = bookID;
        ViewDate = viewDate;
    }
}
