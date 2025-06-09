namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents details of a review for displaying in views.
    /// Does not include the associated user, room, or food item. Includes username.
    /// </summary>
    public class ReviewViewModel
    {
        public string ReviewerUsername { get; set; } = "";
        public int Rating { get; set; }
        public string Comment { get; set; } = "";
        public DateTime ReviewDate { get; set; }
    }
}
