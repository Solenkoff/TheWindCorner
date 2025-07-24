using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWindCorner.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItemEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Item Identifier"),
                    Category = table.Column<int>(type: "int", nullable: false, comment: "The Category of the Item"),
                    ItemType = table.Column<int>(type: "int", nullable: false, comment: "The Type of the Item"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "A short descriptive title for the item"),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "The Size of the Item"),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, comment: "The Brand Name of the Item"),
                    Year = table.Column<int>(type: "int", nullable: false, comment: "The Year of the Item's production or collection"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "A full description of the item"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been approved for listing"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been deleted"),
                    IsSold = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been sold")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                },
                comment: "Item listed for sale or sought after");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
