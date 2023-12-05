public class UserReadItem
{
    public int UserReadID { get; set; }
    public int UserID { get; set; }
    public int BookID { get; set; }

    public UserReadItem(int userReadID, int userID, int bookID)
    {
        UserReadID = userReadID;
        UserID = userID;
        BookID = bookID;
    }
}