﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adventureplatform.Server;

namespace adventureplatform.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200819060710_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("adventureplatform.Shared.Entities.Adventure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Adventures");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.AdventureGenre", b =>
                {
                    b.Property<int>("AdventureID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.HasKey("AdventureID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("AdventureGenres");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.Chapter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdventureID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Event")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Help")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AdventureID");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.Link", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChapterID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Target")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChapterID");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.UserFavourite", b =>
                {
                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdventureID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserEmail", "AdventureID");

                    b.HasIndex("AdventureID");

                    b.HasIndex("UserID");

                    b.ToTable("UserFavourites");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.UserProject", b =>
                {
                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdventureID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserEmail", "AdventureID");

                    b.HasIndex("AdventureID");

                    b.HasIndex("UserID");

                    b.ToTable("UserProjects");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.AdventureGenre", b =>
                {
                    b.HasOne("adventureplatform.Shared.Entities.Adventure", "Adventure")
                        .WithMany("AdventureGenres")
                        .HasForeignKey("AdventureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adventureplatform.Shared.Entities.Genre", "Genre")
                        .WithMany("GenreAdventures")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.Chapter", b =>
                {
                    b.HasOne("adventureplatform.Shared.Entities.Adventure", null)
                        .WithMany("Chapters")
                        .HasForeignKey("AdventureID");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.Link", b =>
                {
                    b.HasOne("adventureplatform.Shared.Entities.Chapter", null)
                        .WithMany("Links")
                        .HasForeignKey("ChapterID");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.UserFavourite", b =>
                {
                    b.HasOne("adventureplatform.Shared.Entities.Adventure", "Favourite")
                        .WithMany("UserFavourites")
                        .HasForeignKey("AdventureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adventureplatform.Shared.Entities.User", "User")
                        .WithMany("UserFavourites")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("adventureplatform.Shared.Entities.UserProject", b =>
                {
                    b.HasOne("adventureplatform.Shared.Entities.Adventure", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("AdventureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adventureplatform.Shared.Entities.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
