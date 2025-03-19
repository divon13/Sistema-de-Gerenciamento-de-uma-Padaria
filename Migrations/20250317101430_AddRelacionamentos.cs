using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PadariaProj.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientesProducoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducaoId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeUsada = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesProducoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientesProducoes_Ingredientes_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesProducoes_Producao_ProducaoId",
                        column: x => x.ProducaoId,
                        principalTable: "Producao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientesVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendaId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeUtilizada = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientesVendas_Ingredientes_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesVendas_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesProducoes_IngredienteId",
                table: "IngredientesProducoes",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesProducoes_ProducaoId",
                table: "IngredientesProducoes",
                column: "ProducaoId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesVendas_IngredienteId",
                table: "IngredientesVendas",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesVendas_VendaId",
                table: "IngredientesVendas",
                column: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientesProducoes");

            migrationBuilder.DropTable(
                name: "IngredientesVendas");
        }
    }
}
