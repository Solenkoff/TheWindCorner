using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheWindCorner.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Image Identifier"),
                    Path = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false, comment: "The path or URL of the image"),
                    EntityType = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The type of entity this image belongs to"),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the entity this image belongs to"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, comment: "The display order of the image, 0 being the main image")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                },
                comment: "Image associated with a listed entity");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "The first name of the user"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "The last name of the user"),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "The path or URL of the user's profile image"),
                    HomeSpotId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "The Identifier of the home spot of the user"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time when the user has been created"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "The date and time when the user has been modified"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the user has been deleted"),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "The date and time when the user has been deleted"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "BlogPost Identifier"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "A short descriptive title for the blog-post"),
                    ShortText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "A summery of the blog-post"),
                    FullText = table.Column<string>(type: "nvarchar(max)", maxLength: 20000, nullable: false, comment: "The full text of the blog-post"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time when the blog-post was added"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the blog-post has been deleted"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the admin who created the blog-post")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "A blog-post posted by the admin");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Item Identifier"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The Category of the Item"),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The Type of the Item"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "A short descriptive title for the item"),
                    Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "The Size of the Item"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "The Brand Name of the Item"),
                    Model = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "The Model Name of the Item"),
                    Year = table.Column<int>(type: "int", nullable: true, comment: "The Year of the Item's production or collection"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "The Price of the Item"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "A full description of the item"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time, when the item was listed for sale"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been approved for listing"),
                    IsSold = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been sold"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the Item has been deleted"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The Identifier of the user who added the item listing")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "Item listed for sale");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the notification"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time the notification was sent"),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the entity that triggered the notification"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The type of the entity"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The type of the notification"),
                    IsRead = table.Column<bool>(type: "bit", nullable: false, comment: "If the notification has been read by the admin"),
                    IsHandled = table.Column<bool>(type: "bit", nullable: false, comment: "If the notified action has been handled by the admin"),
                    TriggeredById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user whose action triggered the notification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_TriggeredById",
                        column: x => x.TriggeredById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "Notification to the admin about user's action");

            migrationBuilder.CreateTable(
                name: "Spots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the spot"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the spot"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "A full description of the spot"),
                    Latitude = table.Column<double>(type: "float", nullable: true, comment: "The latitude of the spot's location"),
                    Longitude = table.Column<double>(type: "float", nullable: true, comment: "The longitude of the spot's location"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time, when the spot was added"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "If the spot has been approved for listing"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the spot has been deleted"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user, who added this spot")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spots_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "A location, where one of the wind-sports can be practiced");

            migrationBuilder.CreateTable(
                name: "WantedItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the wanted item"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The Category of the Item"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "A short descriptive title for the wanted item"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "A full description of the wanted item"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time, when the sought item was listed"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "If the wanted item has been approved for listing"),
                    IsFulfilled = table.Column<bool>(type: "bit", nullable: false, comment: "If the wanted item has been bought"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the wanted item has been deleted"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The Identifier of the user who added the listing of the item they are seeking")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WantedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WantedItems_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "Item that an user is looking for");

            migrationBuilder.CreateTable(
                name: "ItemComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the comment made"),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the item, that was commented"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "The full text of the comment"),
                    CommentedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time the comment was added"),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been edited"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been deleted"),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user, who made the comment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemComments_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                },
                comment: "The comment on an item");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Event Identifier"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "A short descriptive title for the event"),
                    ShortDescription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "A short description of the event"),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false, comment: "A full description of the event"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time, when the event starts"),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time, when the event ends"),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The location, where the event is to be held"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The status of the event"),
                    SpotId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "The Identifier of the spot, where the event takes place"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time when the event was created"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the event has been deleted"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the admin who created the event")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.CheckConstraint("CK_Events_End_After_Start", "[End] > [Start]");
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_Spots_SpotId",
                        column: x => x.SpotId,
                        principalTable: "Spots",
                        principalColumn: "Id");
                },
                comment: "A wind-sports event posted by the admin");

            migrationBuilder.CreateTable(
                name: "SpotComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the comment made"),
                    SpotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the spot, that was commented"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "The full text of the comment"),
                    CommentedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time the comment was added"),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been edited"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been deleted"),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user, who made the comment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpotComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpotComments_Spots_SpotId",
                        column: x => x.SpotId,
                        principalTable: "Spots",
                        principalColumn: "Id");
                },
                comment: "The comment on a spot");

            migrationBuilder.CreateTable(
                name: "WantedItemComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the comment made"),
                    WantedItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the wanted item, that was commented"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "The full text of the comment"),
                    CommentedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time the comment was added"),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been edited"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been deleted"),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user, who made the comment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WantedItemComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WantedItemComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WantedItemComments_WantedItems_WantedItemId",
                        column: x => x.WantedItemId,
                        principalTable: "WantedItems",
                        principalColumn: "Id");
                },
                comment: "The comment on a wanted item");

            migrationBuilder.CreateTable(
                name: "EventComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the comment made"),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the event, that was commented"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "The full text of the comment"),
                    CommentedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The date and time the comment was added"),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been edited"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "If the comment has been deleted"),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The identifier of the user, who made the comment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventComments_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                },
                comment: "The comment on an event");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HomeSpotId",
                table: "AspNetUsers",
                column: "HomeSpotId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CreatedById",
                table: "BlogPosts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventComments_AuthorId",
                table: "EventComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_EventComments_EventId",
                table: "EventComments",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatedById",
                table: "Events",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SpotId",
                table: "Events",
                column: "SpotId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_EntityType_EntityId_DisplayOrder",
                table: "Images",
                columns: new[] { "EntityType", "EntityId", "DisplayOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemComments_AuthorId",
                table: "ItemComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemComments_ItemId",
                table: "ItemComments",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CreatedById",
                table: "Items",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_IsRead_IsHandled",
                table: "Notifications",
                columns: new[] { "IsRead", "IsHandled" });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_TriggeredById",
                table: "Notifications",
                column: "TriggeredById");

            migrationBuilder.CreateIndex(
                name: "IX_SpotComments_AuthorId",
                table: "SpotComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_SpotComments_SpotId",
                table: "SpotComments",
                column: "SpotId");

            migrationBuilder.CreateIndex(
                name: "IX_Spots_CreatedById",
                table: "Spots",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WantedItemComments_AuthorId",
                table: "WantedItemComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_WantedItemComments_WantedItemId",
                table: "WantedItemComments",
                column: "WantedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WantedItems_CreatedById",
                table: "WantedItems",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Spots_HomeSpotId",
                table: "AspNetUsers",
                column: "HomeSpotId",
                principalTable: "Spots",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spots_AspNetUsers_CreatedById",
                table: "Spots");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "EventComments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ItemComments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "SpotComments");

            migrationBuilder.DropTable(
                name: "WantedItemComments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "WantedItems");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Spots");
        }
    }
}
