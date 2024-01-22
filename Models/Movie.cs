namespace MovieRatingApp.Models
{
    public class Movie
    {
        public required string Title { get; set; }
        public int Rating { get; set; } = 3;
    }
}
