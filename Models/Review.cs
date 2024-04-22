using System.ComponentModel.DataAnnotations;


namespace LibraryManagementSystem.Models;
public class Review
{
    [Key]
    public int RatingNumber { get; set; }
    public string Comment { get; set; }

    public List<Book> Books { get; set; }
}