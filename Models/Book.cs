public class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public int AuthorID { get; set; }
    public Author Author { get; set; }
    public int GenreID { get; set; }
    public Genre Genre { get; set; }
    public string Description { get; set; }
    public int PublisherID { get; set; }
    public Publisher Publisher { get; set; }
    public int RatingNumber { get; set; } // Foreign key for Review
    public ICollection<Review> Reviews { get; set; } // One-to-Many relationship
}