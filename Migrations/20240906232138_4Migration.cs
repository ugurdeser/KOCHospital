using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOCHospital.Migrations
{
    /// <inheritdoc />
    public partial class _4Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_doctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_patientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Department_departmentId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_departmentId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_doctorId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "doctorAddress",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "doctorContact",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "doctorEmail",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "doctorExperience",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "doctorSpecialization",
                table: "Doctor",
                newName: "doctorSurname");

            migrationBuilder.RenameColumn(
                name: "doctorQualification",
                table: "Doctor",
                newName: "doctorPhone");

            migrationBuilder.RenameColumn(
                name: "patientId",
                table: "Appointment",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "Appointment",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "appointmentStatus",
                table: "Appointment",
                newName: "AppointmentStatus");

            migrationBuilder.RenameColumn(
                name: "appointmentDate",
                table: "Appointment",
                newName: "AppointmentDate");

            migrationBuilder.RenameColumn(
                name: "appointmentTime",
                table: "Appointment",
                newName: "AppointmentHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_patientId",
                table: "Appointment",
                newName: "IX_Appointment_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "doctorSurname",
                table: "Doctor",
                newName: "doctorSpecialization");

            migrationBuilder.RenameColumn(
                name: "doctorPhone",
                table: "Doctor",
                newName: "doctorQualification");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Appointment",
                newName: "patientId");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Appointment",
                newName: "doctorId");

            migrationBuilder.RenameColumn(
                name: "AppointmentStatus",
                table: "Appointment",
                newName: "appointmentStatus");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointment",
                newName: "appointmentDate");

            migrationBuilder.RenameColumn(
                name: "AppointmentHoursId",
                table: "Appointment",
                newName: "appointmentTime");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointment",
                newName: "IX_Appointment_patientId");

            migrationBuilder.AddColumn<string>(
                name: "doctorAddress",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "doctorContact",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "doctorEmail",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "doctorExperience",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_departmentId",
                table: "Doctor",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_doctorId",
                table: "Appointment",
                column: "doctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Doctor_doctorId",
                table: "Appointment",
                column: "doctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_patientId",
                table: "Appointment",
                column: "patientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Department_departmentId",
                table: "Doctor",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
