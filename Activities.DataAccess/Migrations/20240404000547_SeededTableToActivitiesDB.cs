using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Activities.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeededTableToActivitiesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("0217a480-d818-4c48-82c0-8b0df16c530a"), "music", "London", new DateTime(2024, 6, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5250), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("15b41588-04c9-469c-ac8e-7ccc99df3698"), "drinks", "London", new DateTime(2024, 2, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5230), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("455b6112-ddf9-4827-b561-ab2607509f05"), "film", "London", new DateTime(2024, 12, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5290), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("655dd466-bee1-4304-8074-d0a682888af3"), "culture", "London", new DateTime(2024, 5, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5250), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("676b34fb-93ad-49f4-b340-ac9bad31bdbc"), "culture", "Paris", new DateTime(2024, 3, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5240), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("acb59ef5-d014-43f8-b22e-f328f9734c9e"), "drinks", "London", new DateTime(2024, 9, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5270), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("c066f421-e670-4eac-8a6c-8d87b3c373ea"), "music", "London", new DateTime(2024, 10, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5280), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("c6ed323f-6e34-454c-bbcd-41c8c9ff8bb8"), "travel", "London", new DateTime(2024, 11, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5290), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("d4048f4d-1109-4a7b-80ee-cbe230ff3b38"), "drinks", "London", new DateTime(2024, 8, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5270), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("e276c6af-62d6-4e08-8896-b1525a267894"), "drinks", "London", new DateTime(2024, 7, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5260), "Activity 3 months in future", "Future Activity 3", "Another pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0217a480-d818-4c48-82c0-8b0df16c530a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("15b41588-04c9-469c-ac8e-7ccc99df3698"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("455b6112-ddf9-4827-b561-ab2607509f05"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("655dd466-bee1-4304-8074-d0a682888af3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("676b34fb-93ad-49f4-b340-ac9bad31bdbc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("acb59ef5-d014-43f8-b22e-f328f9734c9e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c066f421-e670-4eac-8a6c-8d87b3c373ea"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c6ed323f-6e34-454c-bbcd-41c8c9ff8bb8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d4048f4d-1109-4a7b-80ee-cbe230ff3b38"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e276c6af-62d6-4e08-8896-b1525a267894"));
        }
    }
}
