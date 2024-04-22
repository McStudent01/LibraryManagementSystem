using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models;
[Table("Genres")]
public class Genre
{
  public int GenreID { get; set; }
  [MaxLength(50)]
  public string GenreName { get; set; }
  [MaxLength(50)]

  public List<Book> Books { get; set; }

}