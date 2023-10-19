using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class TrocaVsUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Troca",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1802), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1811), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1813), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1814), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1816), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1817), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1819), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1821), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1822), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1824), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1825), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1827), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1828), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1830), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1831), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1833), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1834), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1835), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1837), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1838), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1840), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1841), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1843), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1844), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1846), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1847), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1849), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1851), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1852), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1854), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1855), new DateTime(2025, 4, 18, 19, 24, 32, 436, DateTimeKind.Local).AddTicks(1856) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Troca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3857), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3859), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3861), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3862), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3864), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3866), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3868), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3869), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3871), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3872), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3874), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3876), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3877), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3879), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3917), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3919), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3920), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3922), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3925), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3927), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3929), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4262), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4263), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4270), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4271), new DateTime(2025, 4, 18, 19, 13, 25, 720, DateTimeKind.Local).AddTicks(4272) });
        }
    }
}
