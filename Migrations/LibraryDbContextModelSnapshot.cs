﻿// <auto-generated />
using System;
using LibraryManagementSystem.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("BookReview", b =>
                {
                    b.Property<int>("BooksBookID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReviewsRatingNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("BooksBookID", "ReviewsRatingNumber");

                    b.HasIndex("ReviewsRatingNumber");

                    b.ToTable("BookReview");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            FirstName = "Dai",
                            LastName = "Huynh"
                        },
                        new
                        {
                            AuthorID = 2,
                            FirstName = "Fyodor",
                            LastName = "Dostoevsky"
                        },
                        new
                        {
                            AuthorID = 3,
                            FirstName = "Lev",
                            LastName = "Tolstoy"
                        },
                        new
                        {
                            AuthorID = 4,
                            FirstName = "Ann",
                            LastName = "Huynh"
                        },
                        new
                        {
                            AuthorID = 5,
                            FirstName = "Victor",
                            LastName = "Hugo"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BookID1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GenreID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublisherID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookID1");

                    b.HasIndex("GenreID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            AuthorID = 1,
                            BookTitle = "Star Lord",
                            Description = "Description 1",
                            GenreID = 1,
                            PublisherID = 1,
                            RatingNumber = 4
                        },
                        new
                        {
                            BookID = 2,
                            AuthorID = 2,
                            BookTitle = "Into the Backrooms",
                            Description = "Description 2",
                            GenreID = 2,
                            PublisherID = 2,
                            RatingNumber = 5
                        },
                        new
                        {
                            BookID = 3,
                            AuthorID = 4,
                            BookTitle = "Sky Rocket",
                            Description = "Description 3",
                            GenreID = 3,
                            PublisherID = 1,
                            RatingNumber = 3
                        },
                        new
                        {
                            BookID = 4,
                            AuthorID = 3,
                            BookTitle = "The Love of the Sky",
                            Description = "Description 4",
                            GenreID = 4,
                            PublisherID = 2,
                            RatingNumber = 4
                        },
                        new
                        {
                            BookID = 5,
                            AuthorID = 5,
                            BookTitle = "Vietnam War",
                            Description = "Description 5",
                            GenreID = 5,
                            PublisherID = 1,
                            RatingNumber = 5
                        });
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            GenreName = "Science Fiction"
                        },
                        new
                        {
                            GenreID = 2,
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreID = 3,
                            GenreName = "Adventure"
                        },
                        new
                        {
                            GenreID = 4,
                            GenreName = "Romance"
                        },
                        new
                        {
                            GenreID = 5,
                            GenreName = "Historical fiction"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfPublish")
                        .HasColumnType("INTEGER");

                    b.HasKey("PublisherID");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherID = 1,
                            PublisherName = "MCU",
                            YearOfPublish = 2000
                        },
                        new
                        {
                            PublisherID = 2,
                            PublisherName = "DC",
                            YearOfPublish = 2010
                        },
                        new
                        {
                            PublisherID = 3,
                            PublisherName = "DCM",
                            YearOfPublish = 2019
                        });
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Review", b =>
                {
                    b.Property<int>("RatingNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RatingNumber");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            RatingNumber = 1,
                            Comment = "Great book!"
                        },
                        new
                        {
                            RatingNumber = 2,
                            Comment = "Not bad."
                        });
                });

            modelBuilder.Entity("BookReview", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Review", null)
                        .WithMany()
                        .HasForeignKey("ReviewsRatingNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Author", "Authors")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Book", null)
                        .WithMany("Books")
                        .HasForeignKey("BookID1");

                    b.HasOne("LibraryManagementSystem.Models.Genre", "Genres")
                        .WithMany("Books")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Publisher", "Publishers")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authors");

                    b.Navigation("Genres");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
