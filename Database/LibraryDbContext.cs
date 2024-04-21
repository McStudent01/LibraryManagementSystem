using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Database;

public class LibraryDbContext: DbContext
{
  public DbSet<Book> Books { get; set; }
  public DbSet<Author> Authors { get; set; }
  public DbSet<Genre> Genres { get; set; }
  public DbSet<Publisher> Publishers { get; set; }
  public DbSet<Review> Reviews { get; set; }


  public string DbPath  { get; set; }

  public LibraryDbContext()
  {
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    DbPath = System.IO.Path.Join(path, "BookStore.db");
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite($"Data Source={DbPath}");
  }
  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Author>().HasData(
      new Author {AuthorID=1, FirstName="Dai", LastName="Huynh"},
      new Author {AuthorID=2, FirstName="Fyodor", LastName="Dostoevsky"},
      new Author {AuthorID=3, FirstName="Lev", LastName="Tolstoy" },
      new Author {AuthorID=4, FirstName="Ann", LastName="Huynh" },
      new Author {AuthorID=5, FirstName="Victor", LastName="Hugo"}
    );

    modelBuilder.Entity<Book>().HasData(
    new Book { BookID = 1, BookTitle = "Star Lord", Description = "Description 1", AuthorID = 1, GenreID = 1, RatingNumber = 4, PublisherID = 1 },
    new Book { BookID = 2, BookTitle = "Into the Backrooms", Description = "Description 2", AuthorID = 2, GenreID = 2, RatingNumber = 5, PublisherID = 2 },
    new Book { BookID = 3, BookTitle = "Sky Rocket", Description = "Description 3", AuthorID = 4, GenreID = 3, RatingNumber = 3, PublisherID = 1 },
    new Book { BookID = 4, BookTitle = "The Love of the Sky", Description = "Description 4", AuthorID = 3, GenreID = 4, RatingNumber = 4, PublisherID = 2 },
    new Book { BookID = 5, BookTitle = "Vietnam War", Description = "Description 5", AuthorID = 5, GenreID = 5, RatingNumber = 5, PublisherID = 1 }
);


    modelBuilder.Entity<Genre>().HasData(
      new Genre { GenreID=1, GenreName="Science Fiction"},
      new Genre { GenreID=2, GenreName="Horror" },
      new Genre { GenreID=3, GenreName="Adventure"},
      new Genre { GenreID=4, GenreName="Romance"},
      new Genre { GenreID=5, GenreName="Historical fiction"}
    );

    modelBuilder.Entity<Publisher>().HasData(
      new Publisher { PublisherID = 1, PublisherName = "MCU", YearOfPublish = 2000 },
      new Publisher { PublisherID = 2, PublisherName = "DC", YearOfPublish = 2010 },
      new Publisher { PublisherID = 3, PublisherName = "DCM", YearOfPublish = 2019 }
      
    );

      modelBuilder.Entity<Review>().HasData(
        new Review { RatingNumber = 1, Comment = "Great book!" },
        new Review { RatingNumber = 2, Comment = "Not bad." }
    );

    
  }

  }

