using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models;

[Table("Books")]
public class Book
{
    public int BookID { get; set; }
    public string BookTitle { get; set; }
    public int AuthorID { get; set; }
    public int GenreID { get; set; }
    public string Description { get; set; }
    public int PublisherID { get; set; }
    public int RatingNumber { get; set; }




    public virtual List<Book> Books {get; set;}
    public virtual Author Authors { get; set; }
    public virtual Genre Genres { get; set; }
    public virtual Publisher Publishers { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
}