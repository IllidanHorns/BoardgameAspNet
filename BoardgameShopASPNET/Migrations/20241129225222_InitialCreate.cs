using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardgameShop.WEBUI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID_Admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admins__69F567663528856B", x => x.ID_Admin);
                });

            migrationBuilder.CreateTable(
                name: "AttributeTypes",
                columns: table => new
                {
                    ID_AttributeType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeTypeName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attribut__FE87E99414C78373", x => x.ID_AttributeType);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    ID_Photo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkValue = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Photo__DA88631125D6A82C", x => x.ID_Photo);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ID_Category = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductC__6DB3A68AD8FF7755", x => x.ID_Category);
                });

            migrationBuilder.CreateTable(
                name: "RoleAccount",
                columns: table => new
                {
                    ID_RoleAccount = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleAccount = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RoleAccount", x => x.ID_RoleAccount);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValues",
                columns: table => new
                {
                    ID_ValueAttribure = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeType_ID = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attribut__8303888C2DA86DB6", x => x.ID_ValueAttribure);
                    table.ForeignKey(
                        name: "FK__Attribute__Attri__3C34F16F",
                        column: x => x.AttributeType_ID,
                        principalTable: "AttributeTypes",
                        principalColumn: "ID_AttributeType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__522DE4968F8FE3C1", x => x.ID_Product);
                    table.ForeignKey(
                        name: "FK__Products__Catego__1BC821DD",
                        column: x => x.Category_ID,
                        principalTable: "ProductCategories",
                        principalColumn: "ID_Category",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account_user",
                columns: table => new
                {
                    ID_Account = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    RoleAccount_ID = table.Column<int>(type: "int", nullable: false),
                    RoleAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account___213379EB762731C6", x => x.ID_Account);
                    table.ForeignKey(
                        name: "FK_Account_user_RoleAccount_RoleAccountId",
                        column: x => x.RoleAccountId,
                        principalTable: "RoleAccount",
                        principalColumn: "ID_RoleAccount");
                    table.ForeignKey(
                        name: "FK_Account_user_RoleAccount_RoleAccount_ID",
                        column: x => x.RoleAccount_ID,
                        principalTable: "RoleAccount",
                        principalColumn: "ID_RoleAccount");
                });

            migrationBuilder.CreateTable(
                name: "CartPhoto",
                columns: table => new
                {
                    ID_CartPhoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Photo_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CartPhot__D1E8BD53B765CE24", x => x.ID_CartPhoto);
                    table.ForeignKey(
                        name: "FK__CartPhoto__Photo__45BE5BA9",
                        column: x => x.Photo_ID,
                        principalTable: "Photo",
                        principalColumn: "ID_Photo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CartPhoto__Produ__44CA3770",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    ID_Attribute = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: true),
                    ValueAttribute_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductA__9D1EB8026E7A27E8", x => x.ID_Attribute);
                    table.ForeignKey(
                        name: "FK__ProductAt__Produ__40058253",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__ProductAt__Value__40F9A68C",
                        column: x => x.ValueAttribute_ID,
                        principalTable: "AttributeValues",
                        principalColumn: "ID_ValueAttribure",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID_User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MiddleName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Account_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__ED4DE442366EF2E8", x => x.ID_User);
                    table.ForeignKey(
                        name: "FK__Users__Account_I__412EB0B6",
                        column: x => x.Account_ID,
                        principalTable: "Account_user",
                        principalColumn: "ID_Account",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID_Cart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carts__72140ECFA4D762E0", x => x.ID_Cart);
                    table.ForeignKey(
                        name: "FK__Carts__Product_I__245D67DE",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Carts__User_ID__236943A5",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    ID_Favorite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Favorite__FA228CCFEF1766AF", x => x.ID_Favorite);
                    table.ForeignKey(
                        name: "FK__Favorites__Produ__208CD6FA",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Favorites__User___1F98B2C1",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_user_RoleAccount_ID",
                table: "Account_user",
                column: "RoleAccount_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_user_RoleAccountId",
                table: "Account_user",
                column: "RoleAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_AttributeType_ID",
                table: "AttributeValues",
                column: "AttributeType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CartPhoto_Photo_ID",
                table: "CartPhoto",
                column: "Photo_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CartPhoto_Product_ID",
                table: "CartPhoto",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Product_ID",
                table: "Carts",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_User_ID",
                table: "Carts",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_Product_ID",
                table: "Favorites",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "UQ_User_Product",
                table: "Favorites",
                columns: new[] { "User_ID", "Product_ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_Product_ID",
                table: "ProductAttributes",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ValueAttribute_ID",
                table: "ProductAttributes",
                column: "ValueAttribute_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID",
                table: "Products",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "UQ__Products__DD5A978A62F75821",
                table: "Products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Account_ID",
                table: "Users",
                column: "Account_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CartPhoto");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AttributeValues");

            migrationBuilder.DropTable(
                name: "Account_user");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AttributeTypes");

            migrationBuilder.DropTable(
                name: "RoleAccount");
        }
    }
}
