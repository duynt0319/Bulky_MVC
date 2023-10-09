using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBM", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Description", "SWD99901", 99.0, 100.0, 66.0, "Fortune of time" },
                    { 2, "Alice Wonderland", "A thrilling adventure story", "ABC12345", 59.990000000000002, 39.990000000000002, 45.990000000000002, "The Great Adventure" },
                    { 3, "Chef Gordon Ramsay", "A cookbook for aspiring chefs", "XYZ67890", 79.989999999999995, 59.990000000000002, 65.989999999999995, "Cooking Mastery" },
                    { 4, "Historian Jane Smith", "A journey through history", "DEF54321", 49.990000000000002, 34.990000000000002, 39.990000000000002, "History Unveiled" },
                    { 5, "Dr. John Doe", "An introduction to science", "PQR98765", 69.989999999999995, 49.990000000000002, 55.990000000000002, "Science Explained" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
