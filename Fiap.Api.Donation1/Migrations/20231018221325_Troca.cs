using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class Troca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Troca",
                columns: table => new
                {
                    TrocaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProdutoId1 = table.Column<int>(type: "int", nullable: false),
                    ProdutoId2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troca", x => x.TrocaId);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId1",
                        column: x => x.ProdutoId1,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId2",
                        column: x => x.ProdutoId2,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId1",
                table: "Troca",
                column: "ProdutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId2",
                table: "Troca",
                column: "ProdutoId2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4446), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4452), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4456), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4460), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4472), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4482), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4484), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4489), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4490), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4492), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4494), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4495), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4498), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2023, 10, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4644), new DateTime(2025, 4, 11, 18, 58, 7, 720, DateTimeKind.Local).AddTicks(4644) });
        }
    }
}
