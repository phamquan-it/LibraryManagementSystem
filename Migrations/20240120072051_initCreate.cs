using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAdmins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdminEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "tblBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BookCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BookAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BookPub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BookISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Copyright = table.Column<int>(type: "int", nullable: true),
                    DateAdded = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBooks", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "tblTransactions",
                columns: table => new
                {
                    TranId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    BookTItle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BookISBN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TranStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TransDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTransactions", x => x.TranId);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserDep = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAdmins");

            migrationBuilder.DropTable(
                name: "tblBooks");

            migrationBuilder.DropTable(
                name: "tblTransactions");

            migrationBuilder.DropTable(
                name: "tblUsers");
        }
    }
}
