using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Programacion_1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id_Categoria = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Numero_Telefonico = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id_Factura = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha_Realizada = table.Column<string>(nullable: true),
                    Subtotal = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Id_Producto = table.Column<int>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id_Factura);
                });

            migrationBuilder.CreateTable(
                name: "GuiaDeRemisions",
                columns: table => new
                {
                    Id_Guia_Remision = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha_de_Llegada = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiaDeRemisions", x => x.Id_Guia_Remision);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id_Marca = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id_Marca);
                });

            migrationBuilder.CreateTable(
                name: "Proveedors",
                columns: table => new
                {
                    Id_Proveedor = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Numero_Telefonico = table.Column<string>(nullable: false),
                    Detalles = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedors", x => x.Id_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Precio = table.Column<string>(nullable: false),
                    Id_Categoria = table.Column<int>(nullable: false),
                    Id_Marca = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id_Producto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_Id_Categoria",
                        column: x => x.Id_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "Id_Categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_Id_Marca",
                        column: x => x.Id_Marca,
                        principalTable: "Marcas",
                        principalColumn: "Id_Marca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id_Inventario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Guia_Remision = table.Column<int>(nullable: false),
                    Id_Producto = table.Column<int>(nullable: false),
                    Id_Proveedor = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    subTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id_Inventario);
                    table.ForeignKey(
                        name: "FK_Inventarios_GuiaDeRemisions_Id_Guia_Remision",
                        column: x => x.Id_Guia_Remision,
                        principalTable: "GuiaDeRemisions",
                        principalColumn: "Id_Guia_Remision",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Productos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Proveedors_Id_Proveedor",
                        column: x => x.Id_Proveedor,
                        principalTable: "Proveedors",
                        principalColumn: "Id_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Id_Guia_Remision",
                table: "Inventarios",
                column: "Id_Guia_Remision");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Id_Producto",
                table: "Inventarios",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_Id_Proveedor",
                table: "Inventarios",
                column: "Id_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_Categoria",
                table: "Productos",
                column: "Id_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_Marca",
                table: "Productos",
                column: "Id_Marca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "GuiaDeRemisions");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedors");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
