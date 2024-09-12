using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOCHospital.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorQualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Department_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    appointmentTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appointmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_patientId",
                        column: x => x.patientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_doctorId",
                table: "Appointment",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_patientId",
                table: "Appointment",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_departmentId",
                table: "Doctor",
                column: "departmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
