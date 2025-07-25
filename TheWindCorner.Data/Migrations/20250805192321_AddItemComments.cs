using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWindCorner.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItemComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "ItemComment Identifier"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "The full text of the comment"),
                    CommentedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time of the comment"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The identifier of the user, who made the comment"),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the item, that was commented")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemComments_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "The Comment on an item");

            migrationBuilder.CreateIndex(
                name: "IX_ItemComments_ItemId",
                table: "ItemComments",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemComments_UserId",
                table: "ItemComments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemComments");
        }
    }
}
