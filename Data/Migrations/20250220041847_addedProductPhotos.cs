using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_encinasValador.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedProductPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "products");
        }
    }
}
