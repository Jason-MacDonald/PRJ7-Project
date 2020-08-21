using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace adventureplatform.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adventures",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adventures", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Images = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Event = table.Column<string>(nullable: true),
                    Help = table.Column<string>(nullable: true),
                    AdventureID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chapters_Adventures_AdventureID",
                        column: x => x.AdventureID,
                        principalTable: "Adventures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdventureGenres",
                columns: table => new
                {
                    AdventureID = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdventureGenres", x => new { x.AdventureID, x.GenreID });
                    table.ForeignKey(
                        name: "FK_AdventureGenres_Adventures_AdventureID",
                        column: x => x.AdventureID,
                        principalTable: "Adventures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdventureGenres_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavourites",
                columns: table => new
                {
                    UserEmail = table.Column<string>(nullable: false),
                    AdventureID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavourites", x => new { x.UserEmail, x.AdventureID });
                    table.ForeignKey(
                        name: "FK_UserFavourites_Adventures_AdventureID",
                        column: x => x.AdventureID,
                        principalTable: "Adventures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavourites_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    UserEmail = table.Column<string>(nullable: false),
                    AdventureID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => new { x.UserEmail, x.AdventureID });
                    table.ForeignKey(
                        name: "FK_UserProjects_Adventures_AdventureID",
                        column: x => x.AdventureID,
                        principalTable: "Adventures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Target = table.Column<int>(nullable: false),
                    ChapterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Links_Chapters_ChapterID",
                        column: x => x.ChapterID,
                        principalTable: "Chapters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdventureGenres_GenreID",
                table: "AdventureGenres",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_AdventureID",
                table: "Chapters",
                column: "AdventureID");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ChapterID",
                table: "Links",
                column: "ChapterID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavourites_AdventureID",
                table: "UserFavourites",
                column: "AdventureID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavourites_UserID",
                table: "UserFavourites",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_AdventureID",
                table: "UserProjects",
                column: "AdventureID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserID",
                table: "UserProjects",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdventureGenres");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "UserFavourites");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Adventures");
        }
    }
}
