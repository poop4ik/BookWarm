public class UserPreferenceItem
{
    public int PreferenceID { get; set; }
    public int UserID { get; set; }
    public int BookID { get; set; }

    public UserPreferenceItem(int preferenceID, int userID, int bookID)
    {
        PreferenceID = preferenceID;
        UserID = userID;
        BookID = bookID;
    }
}