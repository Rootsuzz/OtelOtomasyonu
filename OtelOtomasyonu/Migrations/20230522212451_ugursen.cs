using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtelOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class ugursen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Odalars",
                columns: table => new
                {
                    OdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdaKat = table.Column<int>(type: "int", nullable: false),
                    OdaNumarasi = table.Column<int>(type: "int", nullable: false),
                    KisiSayisi = table.Column<int>(type: "int", nullable: false),
                    KiralanmaDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalars", x => x.OdaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odalars");
        }
    }
}
