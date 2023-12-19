using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddContact.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Category", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 1, 2, "jinny.park@gmail.com", "Jinny", "Park", 123456789 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Category", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 2, 1, "amr.shier@yahoo.com", "Amr", "Shier", 987654321 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Category", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 3, 0, "rawda.email@gmail.com", "Rawda", "Emad", 547354311 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
