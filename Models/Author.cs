using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models;

[Table("Authors")]
public class Author
{
    public int AuthorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public List<Book> Books { get; set; }
}