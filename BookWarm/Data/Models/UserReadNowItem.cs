public class UserReadNowItem
{
    public int UserReadNowID { get; set; }
    public int UserID { get; set; }
    public int BookID { get; set; }

    public UserReadNowItem(int userReadNowID, int userID, int bookID)
    {
        UserReadNowID = userReadNowID;
        UserID = userID;
        BookID = bookID;
    }
}