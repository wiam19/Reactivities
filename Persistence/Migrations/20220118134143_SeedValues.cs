using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("0bdf0f3f-affe-4bb7-8b87-51ff2265db70"), "drinks", "London", new DateTime(2022, 4, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6145), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("43f11f17-6604-43fd-b616-2561f43241b6"), "music", "London", new DateTime(2022, 3, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6139), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("6ba56bd1-a02a-46f3-966f-70f963151141"), "travel", "London", new DateTime(2022, 8, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6174), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("775e1d6b-377c-41c8-a948-8b1bf0dc797f"), "culture", "Paris", new DateTime(2021, 12, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6125), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("7b84a4d8-b64e-4c29-80d3-f4f0f45fcaf6"), "drinks", "London", new DateTime(2022, 6, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6157), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("820504b8-75a0-488e-b15d-4a48878d5c9e"), "film", "London", new DateTime(2022, 9, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6180), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("825aaf40-38bc-494b-a22e-fa357468c172"), "culture", "London", new DateTime(2022, 2, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6132), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("c298baa3-a5e0-4d5e-8f97-2cec6b98fc12"), "drinks", "London", new DateTime(2021, 11, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6062), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("caf9e8dd-97ee-41b5-8590-7eb5cc4fcaab"), "music", "London", new DateTime(2022, 7, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6163), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("f5fd9287-e94a-43da-b775-17a0ab3da575"), "drinks", "London", new DateTime(2022, 5, 18, 14, 41, 43, 377, DateTimeKind.Local).AddTicks(6151), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("0bdf0f3f-affe-4bb7-8b87-51ff2265db70"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("43f11f17-6604-43fd-b616-2561f43241b6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("6ba56bd1-a02a-46f3-966f-70f963151141"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("775e1d6b-377c-41c8-a948-8b1bf0dc797f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("7b84a4d8-b64e-4c29-80d3-f4f0f45fcaf6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("820504b8-75a0-488e-b15d-4a48878d5c9e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("825aaf40-38bc-494b-a22e-fa357468c172"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("c298baa3-a5e0-4d5e-8f97-2cec6b98fc12"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("caf9e8dd-97ee-41b5-8590-7eb5cc4fcaab"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: new Guid("f5fd9287-e94a-43da-b775-17a0ab3da575"));
        }
    }
}
