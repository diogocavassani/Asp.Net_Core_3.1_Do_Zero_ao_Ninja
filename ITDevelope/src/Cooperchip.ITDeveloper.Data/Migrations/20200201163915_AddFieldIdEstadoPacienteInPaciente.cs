using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cooperchip.ITDeveloper.Data.Migrations
{
    public partial class AddFieldIdEstadoPacienteInPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EstadoPacienteId",
                table: "Paciente",
                nullable: false,
                defaultValue: new Guid("97b324fc-a8ae-4128-9a15-329215cc1c82"));

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_EstadoPacienteId",
                table: "Paciente",
                column: "EstadoPacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente",
                column: "EstadoPacienteId",
                principalTable: "EstadoPaciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_EstadoPacienteId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EstadoPacienteId",
                table: "Paciente");
        }
    }
}
