using Microsoft.EntityFrameworkCore.Migrations;

namespace DataEntryApplication.Server.Data.Migations
{
    public partial class CMD2table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMD2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L1 = table.Column<string>(nullable: true),
                    L2 = table.Column<string>(nullable: true),
                    L3 = table.Column<string>(nullable: true),
                    L4 = table.Column<string>(nullable: true),
                    L5 = table.Column<string>(nullable: true),
                    L6 = table.Column<string>(nullable: true),
                    L7 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMD2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMD2");
        }
    }
}
