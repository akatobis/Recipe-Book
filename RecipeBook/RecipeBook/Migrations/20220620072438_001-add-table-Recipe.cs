using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Migrations
{
    public partial class _001addtableRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CookingTime = table.Column<int>(type: "int", nullable: false),
                    Portions = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipeLikesCount = table.Column<int>(type: "int", nullable: false),
                    RecipeFavouritesCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "recipe_part",
                columns: table => new
                {
                    RecipePartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RecipeIngredients = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_part", x => x.RecipePartId);
                    table.ForeignKey(
                        name: "FK_recipe_part_recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recipe_step",
                columns: table => new
                {
                    RecipeStepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_step", x => x.RecipeStepId);
                    table.ForeignKey(
                        name: "FK_recipe_step_recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recipe_tag",
                columns: table => new
                {
                    RecipeTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_tag", x => x.RecipeTagId);
                    table.ForeignKey(
                        name: "FK_recipe_tag_recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipe_part_RecipeId",
                table: "recipe_part",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_step_RecipeId",
                table: "recipe_step",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_tag_RecipeId",
                table: "recipe_tag",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipe_part");

            migrationBuilder.DropTable(
                name: "recipe_step");

            migrationBuilder.DropTable(
                name: "recipe_tag");

            migrationBuilder.DropTable(
                name: "recipe");
        }
    }
}
