using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP2084_a1_shoestore.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Footwear",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footwear", x => x.FootwearId);
                });

            migrationBuilder.CreateTable(
                name: "ShoeType",
                columns: table => new
                {
                    ShoeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FootwearId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeType", x => x.ShoeTypeId);
                    table.ForeignKey(
                        name: "FK_ShoeType_Footwear_FootwearId",
                        column: x => x.FootwearId,
                        principalTable: "Footwear",
                        principalColumn: "FootwearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shoe",
                columns: table => new
                {
                    ShoeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShoeTypeId = table.Column<int>(nullable: false),
                    ShoeName = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoe", x => x.ShoeId);
                    table.ForeignKey(
                        name: "FK_Shoe_ShoeType_ShoeTypeId",
                        column: x => x.ShoeTypeId,
                        principalTable: "ShoeType",
                        principalColumn: "ShoeTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoeType_FootwearId",
                table: "ShoeType",
                column: "FootwearId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoe_ShoeTypeId",
                table: "Shoe",
                column: "ShoeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoe");

            migrationBuilder.DropTable(
                name: "ShoeType");

            migrationBuilder.DropTable(
                name: "Footwear");
        }
    }
}
