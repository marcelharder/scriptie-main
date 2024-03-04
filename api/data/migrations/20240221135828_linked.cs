using Microsoft.EntityFrameworkCore.Migrations;

namespace scriptie.data.migrations
{
    public partial class linked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cas_Patients_patientId",
                table: "cas");

            migrationBuilder.DropForeignKey(
                name: "FK_glis_Patients_patientId",
                table: "glis");

            migrationBuilder.DropIndex(
                name: "IX_glis_patientId",
                table: "glis");

            migrationBuilder.DropIndex(
                name: "IX_cas_patientId",
                table: "cas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "glis");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "cas");

            migrationBuilder.RenameColumn(
                name: "patientId",
                table: "glis",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "patientId",
                table: "cas",
                newName: "PatientId");

            migrationBuilder.AddColumn<string>(
                name: "ERV",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FEV1",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IC",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RV",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TLC",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VC",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "glis",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "cas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_glis_PatientId",
                table: "glis",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cas_PatientId",
                table: "cas",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cas_Patients_PatientId",
                table: "cas",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_glis_Patients_PatientId",
                table: "glis",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cas_Patients_PatientId",
                table: "cas");

            migrationBuilder.DropForeignKey(
                name: "FK_glis_Patients_PatientId",
                table: "glis");

            migrationBuilder.DropIndex(
                name: "IX_glis_PatientId",
                table: "glis");

            migrationBuilder.DropIndex(
                name: "IX_cas_PatientId",
                table: "cas");

            migrationBuilder.DropColumn(
                name: "ERV",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "FEV1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IC",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RV",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TLC",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VC",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "glis",
                newName: "patientId");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "cas",
                newName: "patientId");

            migrationBuilder.AlterColumn<int>(
                name: "patientId",
                table: "glis",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "glis",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "patientId",
                table: "cas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "cas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_glis_patientId",
                table: "glis",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_cas_patientId",
                table: "cas",
                column: "patientId");

            migrationBuilder.AddForeignKey(
                name: "FK_cas_Patients_patientId",
                table: "cas",
                column: "patientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_glis_Patients_patientId",
                table: "glis",
                column: "patientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
