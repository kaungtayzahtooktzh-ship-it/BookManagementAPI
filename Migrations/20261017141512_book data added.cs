using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class bookdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Book_id", "Author", "Public_year", "Title" },
                values: new object[,]
                {
                    { 1, "Harper Lee", 1960, "To Kill a Mockingbird" },
                    { 2, "George Orwell", 1949, "1984" },
                    { 3, "F. Scott Fitzgerald", 1813, "The Great Gatsby" },
                    { 4, "Jane Austen", 1813, "Pride and Prejudice" },
                    { 5, "J.R.R Tolkien", 1937, "The Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_id",
                keyValue: 5);
        }
    }
}
