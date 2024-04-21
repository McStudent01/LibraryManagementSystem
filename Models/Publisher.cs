
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models;
public class Publisher
{
    [Key]
    public int PublisherID { get; set; }
    public string PublisherName { get; set; }
    public int YearOfPublish { get; set; }
    public List<Book> Books { get; set; }
}