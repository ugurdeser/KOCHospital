using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOCHospital.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "patientEmail",
                table: "Patient",
                newName: "patientPhone");

            migrationBuilder.RenameColumn(
                name: "patientContact",
                table: "Patient",
                newName: "patientLastName");

            migrationBuilder.RenameColumn(
                name: "patientAddress",
                table: "Patient",
                newName: "governmentId");

            migrationBuilder.AddColumn<DateTime>(
                name: "patientBirthDate",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "patientBirthDate",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "patientPhone",
                table: "Patient",
                newName: "patientEmail");

            migrationBuilder.RenameColumn(
                name: "patientLastName",
                table: "Patient",
                newName: "patientContact");

            migrationBuilder.RenameColumn(
                name: "governmentId",
                table: "Patient",
                newName: "patientAddress");
        }
    }
}
