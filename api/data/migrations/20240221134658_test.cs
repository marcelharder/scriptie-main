using Microsoft.EntityFrameworkCore.Migrations;

namespace scriptie.data.migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cas",
                columns: table => new
                {
                    CasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    measured = table.Column<string>(type: "TEXT", nullable: true),
                    predicted = table.Column<string>(type: "TEXT", nullable: true),
                    zscore = table.Column<string>(type: "TEXT", nullable: true),
                    LLN = table.Column<string>(type: "TEXT", nullable: true),
                    ULN = table.Column<string>(type: "TEXT", nullable: true),
                    Perc_Predicted = table.Column<string>(type: "TEXT", nullable: true),
                    BDR_perc_changed = table.Column<string>(type: "TEXT", nullable: true),
                    patientId = table.Column<int>(type: "INTEGER", nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cas", x => x.CasId);
                    table.ForeignKey(
                        name: "FK_cas_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "glis",
                columns: table => new
                {
                    GliId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    measured = table.Column<string>(type: "TEXT", nullable: true),
                    predicted = table.Column<string>(type: "TEXT", nullable: true),
                    zscore = table.Column<string>(type: "TEXT", nullable: true),
                    LLN = table.Column<string>(type: "TEXT", nullable: true),
                    ULN = table.Column<string>(type: "TEXT", nullable: true),
                    Perc_Predicted = table.Column<string>(type: "TEXT", nullable: true),
                    BDR_perc_changed = table.Column<string>(type: "TEXT", nullable: true),
                    patientId = table.Column<int>(type: "INTEGER", nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_glis", x => x.GliId);
                    table.ForeignKey(
                        name: "FK_glis_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cas_patientId",
                table: "cas",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_glis_patientId",
                table: "glis",
                column: "patientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cas");

            migrationBuilder.DropTable(
                name: "glis");
        }
    }
}
