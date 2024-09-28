using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace one_many.Migrations
{
    /// <inheritdoc />
    public partial class onemanycustomforign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Licencse = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.UniqueConstraint("AK_Car_Licencse_state", x => new { x.Licencse, x.state });
                });

            migrationBuilder.CreateTable(
                name: "RecordSale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carLicense = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    carState = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordSale_Car_carLicense_carState",
                        columns: x => new { x.carLicense, x.carState },
                        principalTable: "Car",
                        principalColumns: new[] { "Licencse", "state" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordSale_carLicense_carState",
                table: "RecordSale",
                columns: new[] { "carLicense", "carState" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordSale");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
