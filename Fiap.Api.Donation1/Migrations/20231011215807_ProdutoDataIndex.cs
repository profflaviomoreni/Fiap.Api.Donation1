using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class ProdutoDataIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "DataCadastro", "DataExpiracao", "Descricao", "Disponivel", "Nome", "SugestaoTroca", "TipoProdutoId", "UsuarioId", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4427), "Descrição", true, "Produto 1", "Sugestão de troca", 1, 1, 1.0 },
                    { 2, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4444), "Descrição", true, "Produto 2", "Sugestão de troca", 1, 1, 1.0 },
                    { 3, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4446), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4446), "Descrição", true, "Produto 3", "Sugestão de troca", 1, 1, 1.0 },
                    { 4, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4448), "Descrição", true, "Produto 4", "Sugestão de troca", 1, 1, 1.0 },
                    { 5, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4450), "Descrição", true, "Produto 5", "Sugestão de troca", 1, 1, 1.0 },
                    { 6, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4452), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4452), "Descrição", true, "Produto 6", "Sugestão de troca", 1, 1, 1.0 },
                    { 7, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4456), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4457), "Descrição", true, "Produto 7", "Sugestão de troca", 1, 1, 1.0 },
                    { 8, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4458), "Descrição", true, "Produto 8", "Sugestão de troca", 1, 1, 1.0 },
                    { 9, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4460), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4460), "Descrição", true, "Produto 9", "Sugestão de troca", 1, 1, 1.0 },
                    { 10, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4466), "Descrição", true, "Produto 10", "Sugestão de troca", 1, 1, 1.0 },
                    { 11, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4468), "Descrição", true, "Produto 11", "Sugestão de troca", 1, 1, 1.0 },
                    { 12, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4470), "Descrição", true, "Produto 12", "Sugestão de troca", 1, 1, 1.0 },
                    { 13, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4471), "Descrição", true, "Produto 13", "Sugestão de troca", 1, 1, 1.0 },
                    { 14, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4472), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4473), "Descrição", true, "Produto 14", "Sugestão de troca", 1, 1, 1.0 },
                    { 15, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4474), "Descrição", true, "Produto 15", "Sugestão de troca", 1, 1, 1.0 },
                    { 16, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4476), "Descrição", true, "Produto 16", "Sugestão de troca", 1, 1, 1.0 },
                    { 17, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4478), "Descrição", true, "Produto 17", "Sugestão de troca", 1, 1, 1.0 },
                    { 18, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4479), "Descrição", true, "Produto 18", "Sugestão de troca", 1, 1, 1.0 },
                    { 19, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4481), "Descrição", true, "Produto 19", "Sugestão de troca", 1, 1, 1.0 },
                    { 20, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4482), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4483), "Descrição", true, "Produto 20", "Sugestão de troca", 1, 1, 1.0 },
                    { 21, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4484), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4484), "Descrição", true, "Produto 21", "Sugestão de troca", 1, 1, 1.0 },
                    { 22, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4486), "Descrição", true, "Produto 22", "Sugestão de troca", 1, 1, 1.0 },
                    { 23, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4488), "Descrição", true, "Produto 23", "Sugestão de troca", 1, 1, 1.0 },
                    { 24, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4489), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4489), "Descrição", true, "Produto 24", "Sugestão de troca", 1, 1, 1.0 },
                    { 25, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4490), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4491), "Descrição", true, "Produto 25", "Sugestão de troca", 1, 1, 1.0 },
                    { 26, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4492), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4492), "Descrição", true, "Produto 26", "Sugestão de troca", 1, 1, 1.0 },
                    { 27, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4494), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4494), "Descrição", true, "Produto 27", "Sugestão de troca", 1, 1, 1.0 },
                    { 28, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4495), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4495), "Descrição", true, "Produto 28", "Sugestão de troca", 1, 1, 1.0 },
                    { 29, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4497), "Descrição", true, "Produto 29", "Sugestão de troca", 1, 1, 1.0 },
                    { 30, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4498), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4498), "Descrição", true, "Produto 30", "Sugestão de troca", 1, 1, 1.0 },
                    { 31, new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4644), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4644), "Descrição", true, "Produto 31", "Sugestão de troca", 1, 1, 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto",
                column: "DataCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31);
        }
    }
}
