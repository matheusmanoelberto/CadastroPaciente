using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CadastroPaciente.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class base_fornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(120)", nullable: true),
                    Email = table.Column<string>(type: "varchar(120)", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Cpf_Or_Cnpj = table.Column<string>(type: "varchar(14)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(9)", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fornecedor");
        }
    }
}
