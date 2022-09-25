using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "FirstName", "LastName", "PageCount" },
                values: new object[] { 1, "Laivai", "Antanas", "Smetona", 400 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "FirstName", "LastName", "PageCount" },
                values: new object[] { 2, "Karas ir taika", "Stasys", "Povilaitis", 50 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "FirstName", "LastName", "PageCount" },
                values: new object[] { 3, "Statyba", "Lukas", "Lukys", 25 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "FirstName", "LastName", "PageCount" },
                values: new object[] { 4, "Laivyba", "Antanas", "Smetona", 350 });   

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "FirstName", "LastName", "PageCount" },
                values: new object[] { 5, "Langai", "Stasys", "Povilaitis", 400 });    

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
