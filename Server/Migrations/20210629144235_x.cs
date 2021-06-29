using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionizerProject.Server.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Visits = table.Column<int>(type: "int", nullable: false),
                    LastVisit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "phone", "Phones", "phones" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "watch", "Smartwatches", "smartwatches" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "aperture", "Earphones", "ear-phones" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8Qrz_OM7sCi3Rj_Z6i1uiVKpcAn1Oss5iviR2FkUQ9w1xnNlLbIPRY9povLrspM6xNqUVoE7q&usqp=CAc", false, false, "Apple iPhone 12 Red 128GB", 0 },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8OTZkRMoSQMPy8Non_tDaKgZAysx3Lm67To0xpvVxNgbFLgfalvQrsB0s9aG3coUhjSGPPCg&usqp=CAc", false, false, "Apple iPhone 12 Blue 128GB", 0 },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQD3ODxjJaqY11RN31VZkuG9xyHRehQgW-jo5XAJfw6zDEHAV9tcARWtrgr1xQbi3yJDm6RoV8&usqp=CAc", false, false, "Apple iPhone 12 Gold 64GB", 0 },
                    { 4, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The sixth generation of the Apple Watch was revealed during the September 15, 2020 Time Flies Apple Event. Additional new features include a new S6 processor (that is up to 20% faster than the S4 and S5),[98] a brighter always-on display, a blood oxygen app that works with a new in-watch sensor and an always-on altimeter.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhQRINSKm8QQsa92OWjg0RVSEvdoGieYhsKqX9mJbuDbidnxsB1W611GwqDA&usqp=CAc", false, false, "AppleWatch S6", 0 },
                    { 5, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Apple Watch SE only uses the S5 processor, does not have the ECG app and Blood Oxygen Sensor, and only comes with the 2nd generation Optical Heart Rate Sensor.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvzbfgTdpER5-rcDxRNb-wgfTDybd0U08fTy1NUpIGFLYCe8HFfZT9bnGSpd2COBFbPWvgIZk&usqp=CAc", false, false, "AppleWatch Special Edition Nude", 0 },
                    { 6, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Apple Watch SE only uses the S5 processor, does not have the ECG app and Blood Oxygen Sensor, and only comes with the 2nd generation Optical Heart Rate Sensor.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStNAwkZtftUGIGQg0iMxVJkUq8uQ9_QlOokhRzOW9VVAg479qciaSF8MoivMU&usqp=CAc", false, false, "AppleWatch Special Edition Black", 0 },
                    { 7, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, " They are the same design as the first generation, but have updated features.[21] They include an H1 processor which supports hands-free 'Hey Siri', Bluetooth 5 connectivity. Apple also claims 50% more talk time and faster device connection times.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZgMnY0Hoxn1DiEq8iAGTdDnz81KD8Lnocml2CMAmb-e5ydSm4gDOQMGZ-C4lXHukcgsXpWxE&usqp=CAc", false, false, "Apple Airpods 2", 0 },
                    { 8, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The AirPods Pro use the H1 chip also found in second-generation AirPods that supports hands-free 'Hey Siri'. They have active noise cancellation, accomplished by microphones detecting outside sound and speakers producing precisely opposite 'anti - noise'.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjzRbltmbqjR3qvPHNPw0T6F53tttudpBly67ceHs4_7_cB7vUQOX2xvPk0cwntolBYy23vAc&usqp=CAc", false, false, "Apple AirPods Pro", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
