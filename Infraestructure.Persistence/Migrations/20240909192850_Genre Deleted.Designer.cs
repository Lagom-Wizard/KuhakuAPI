﻿// <auto-generated />
using System;
using Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(KhakuContext))]
    [Migration("20240909192850_Genre Deleted")]
    partial class GenreDeleted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Domain.Entities.GeneralMovie.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Core.Domain.Entities.GeneralMovie.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("Adult")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Backdrop_path")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Original_title")
                        .HasColumnType("longtext");

                    b.Property<string>("Overview")
                        .HasColumnType("longtext");

                    b.Property<string>("Poster_path")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Release_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TMDBID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Video")
                        .HasColumnType("longtext");

                    b.Property<double?>("Vote_average")
                        .HasColumnType("double");

                    b.Property<int?>("Vote_count")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.Genre_Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.HasIndex("MovieID");

                    b.ToTable("Genre_Movie", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.MovieList_Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("MovieListID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("MovieListID");

                    b.ToTable("MovieList_Movie", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.Movie_MovieWeb", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("MovieWebID")
                        .HasColumnType("int");

                    b.Property<bool>("Verified")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("MovieWebID");

                    b.ToTable("Movie_MovieWeb", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.User.UserEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("UserEntity", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.UserThings.MovieList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserEntityID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserEntityID");

                    b.ToTable("MovieList", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.UserThings.Recents", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("UserEntityID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserEntityID");

                    b.ToTable("Recents", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.WebScraping.MovieWeb", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ScrapPageID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ScrapPageID");

                    b.ToTable("MovieWeb", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.WebScraping.ScrapPage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsOn")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastScrap")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("ScrapPage", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.Genre_Movie", b =>
                {
                    b.HasOne("Core.Domain.Entities.GeneralMovie.Genre", "Genre")
                        .WithMany("Genre_Movie")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.GeneralMovie.Movie", "Movie")
                        .WithMany("Genre_Movie")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.MovieList_Movie", b =>
                {
                    b.HasOne("Core.Domain.Entities.GeneralMovie.Movie", "Movie")
                        .WithMany("MovieList_Movie")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.UserThings.MovieList", "MovieList")
                        .WithMany("MovieList_Movie")
                        .HasForeignKey("MovieListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("MovieList");
                });

            modelBuilder.Entity("Core.Domain.Entities.Relations.Movie_MovieWeb", b =>
                {
                    b.HasOne("Core.Domain.Entities.GeneralMovie.Movie", "Movie")
                        .WithMany("Movie_MovieWeb")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.WebScraping.MovieWeb", "MovieWeb")
                        .WithMany("Movie_MovieWeb")
                        .HasForeignKey("MovieWebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("MovieWeb");
                });

            modelBuilder.Entity("Core.Domain.Entities.UserThings.MovieList", b =>
                {
                    b.HasOne("Core.Domain.Entities.User.UserEntity", "UserEntity")
                        .WithMany("MovieLists")
                        .HasForeignKey("UserEntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Core.Domain.Entities.UserThings.Recents", b =>
                {
                    b.HasOne("Core.Domain.Entities.GeneralMovie.Movie", "Movie")
                        .WithMany("Recents")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User.UserEntity", "UserEntity")
                        .WithMany("Recents")
                        .HasForeignKey("UserEntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Core.Domain.Entities.WebScraping.MovieWeb", b =>
                {
                    b.HasOne("Core.Domain.Entities.WebScraping.ScrapPage", "ScrapPage")
                        .WithMany("MovieWeb")
                        .HasForeignKey("ScrapPageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScrapPage");
                });

            modelBuilder.Entity("Core.Domain.Entities.GeneralMovie.Genre", b =>
                {
                    b.Navigation("Genre_Movie");
                });

            modelBuilder.Entity("Core.Domain.Entities.GeneralMovie.Movie", b =>
                {
                    b.Navigation("Genre_Movie");

                    b.Navigation("MovieList_Movie");

                    b.Navigation("Movie_MovieWeb");

                    b.Navigation("Recents");
                });

            modelBuilder.Entity("Core.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("MovieLists");

                    b.Navigation("Recents");
                });

            modelBuilder.Entity("Core.Domain.Entities.UserThings.MovieList", b =>
                {
                    b.Navigation("MovieList_Movie");
                });

            modelBuilder.Entity("Core.Domain.Entities.WebScraping.MovieWeb", b =>
                {
                    b.Navigation("Movie_MovieWeb");
                });

            modelBuilder.Entity("Core.Domain.Entities.WebScraping.ScrapPage", b =>
                {
                    b.Navigation("MovieWeb");
                });
#pragma warning restore 612, 618
        }
    }
}
