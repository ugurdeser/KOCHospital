using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOCHospital.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PatientHistory",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "patientPhone",
                table: "Patient",
                newName: "PatientPhone");

            migrationBuilder.RenameColumn(
                name: "patientName",
                table: "Patient",
                newName: "PatientName");

            migrationBuilder.RenameColumn(
                name: "patientLastName",
                table: "Patient",
                newName: "PatientLastName");

            migrationBuilder.RenameColumn(
                name: "patientGender",
                table: "Patient",
                newName: "PatientGender");

            migrationBuilder.RenameColumn(
                name: "patientBirthDate",
                table: "Patient",
                newName: "PatientBirthDate");

            migrationBuilder.RenameColumn(
                name: "governmentId",
                table: "Patient",
                newName: "GovernmentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patient",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "doctorSurname",
                table: "Doctor",
                newName: "DoctorSurname");

            migrationBuilder.RenameColumn(
                name: "doctorPhone",
                table: "Doctor",
                newName: "DoctorPhone");

            migrationBuilder.RenameColumn(
                name: "doctorName",
                table: "Doctor",
                newName: "DoctorName");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Doctor",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctor",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "departmentName",
                table: "Department",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "departmentDescription",
                table: "Department",
                newName: "DepartmentDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Department",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Appointment",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PatientHistory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PatientPhone",
                table: "Patient",
                newName: "patientPhone");

            migrationBuilder.RenameColumn(
                name: "PatientName",
                table: "Patient",
                newName: "patientName");

            migrationBuilder.RenameColumn(
                name: "PatientLastName",
                table: "Patient",
                newName: "patientLastName");

            migrationBuilder.RenameColumn(
                name: "PatientGender",
                table: "Patient",
                newName: "patientGender");

            migrationBuilder.RenameColumn(
                name: "PatientBirthDate",
                table: "Patient",
                newName: "patientBirthDate");

            migrationBuilder.RenameColumn(
                name: "GovernmentId",
                table: "Patient",
                newName: "governmentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Patient",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorSurname",
                table: "Doctor",
                newName: "doctorSurname");

            migrationBuilder.RenameColumn(
                name: "DoctorPhone",
                table: "Doctor",
                newName: "doctorPhone");

            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "Doctor",
                newName: "doctorName");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Doctor",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Doctor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Department",
                newName: "departmentName");

            migrationBuilder.RenameColumn(
                name: "DepartmentDescription",
                table: "Department",
                newName: "departmentDescription");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Appointment",
                newName: "Id");
        }
    }
}
