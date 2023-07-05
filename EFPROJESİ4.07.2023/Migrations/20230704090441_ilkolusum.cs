using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFPROJESİ4._07._2023.Migrations
{
    public partial class ilkolusum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todoItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "todoItems",
                columns: new[] { "Id", "Done", "Title" },
                values: new object[,]
                {
                    { 1, false, "Proje teklifini tamamla" },
                    { 2, false, "Sunum slaytlarını hazırla" },
                    { 3, true, "Kod değişikliklerini gözden geçir" },
                    { 4, true, "Takip e-postalarını gönder" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todoItems");
        }
    }
}
