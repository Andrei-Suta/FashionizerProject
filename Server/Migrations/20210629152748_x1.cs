using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionizerProject.Server.Migrations
{
    public partial class x1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "64GB" },
                    { 2, "128GB" },
                    { 3, "256GB" },
                    { 4, "White" },
                    { 5, "Black" },
                    { 6, "Nude" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 3899.99m, 3899.99m },
                    { 5, 8, 0m, 1099.99m },
                    { 5, 7, 0m, 649.99m },
                    { 5, 6, 0m, 1499.99m },
                    { 5, 4, 0m, 1999.99m },
                    { 4, 8, 0m, 1099.99m },
                    { 4, 7, 0m, 649.99m },
                    { 6, 4, 0m, 1999.99m },
                    { 3, 3, 5599.99m, 5299.99m },
                    { 3, 1, 5599.99m, 5299.99m },
                    { 2, 3, 0m, 4499.99m },
                    { 2, 2, 0m, 4499.99m },
                    { 2, 1, 0m, 4499.99m },
                    { 1, 3, 3899.99m, 3899.99m },
                    { 1, 2, 3899.99m, 3899.99m },
                    { 3, 2, 5599.00m, 5299.66m },
                    { 6, 5, 1499.99m, 999.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
