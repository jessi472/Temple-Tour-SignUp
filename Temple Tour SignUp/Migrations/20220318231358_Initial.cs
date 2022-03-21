using Microsoft.EntityFrameworkCore.Migrations;

namespace Temple_Tour_SignUp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlotResponse",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Taken = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlotResponse", x => x.TimeSlotId);
                });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 1, "03-20-2022", true, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 66, "03-25-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 65, "03-24-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 64, "03-24-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 63, "03-24-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 62, "03-24-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 61, "03-24-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 60, "03-24-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 59, "03-24-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 58, "03-24-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 57, "03-24-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 56, "03-24-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 55, "03-24-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 54, "03-24-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 53, "03-24-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 52, "03-23-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 51, "03-23-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 50, "03-23-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 49, "03-23-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 48, "03-23-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 67, "03-25-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 47, "03-23-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 68, "03-25-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 70, "03-25-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 89, "03-26-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 88, "03-26-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 87, "03-26-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 86, "03-26-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 85, "03-26-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 84, "03-26-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 83, "03-26-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 82, "03-26-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 81, "03-26-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 80, "03-26-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 79, "03-26-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 78, "03-25-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 77, "03-25-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 76, "03-25-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 75, "03-25-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 74, "03-25-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 73, "03-25-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 72, "03-25-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 71, "03-25-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 69, "03-25-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 90, "03-26-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 46, "03-23-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 44, "03-23-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 20, "03-21-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 19, "03-21-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 18, "03-21-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 17, "03-21-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 16, "03-21-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 15, "03-21-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 14, "03-21-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 13, "03-20-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 12, "03-20-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 11, "03-20-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 10, "03-20-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 9, "03-20-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 8, "03-20-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 7, "03-20-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 6, "03-20-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 5, "03-20-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 4, "03-20-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 3, "03-20-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 2, "03-20-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 21, "03-21-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 45, "03-23-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 22, "03-21-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 24, "03-21-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 43, "03-23-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 42, "03-23-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 41, "03-23-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 40, "03-23-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 39, "03-22-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 38, "03-22-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 37, "03-22-2022", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 36, "03-22-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 35, "03-22-2022", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 34, "03-22-2022", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 33, "03-22-2022", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 32, "03-22-2022", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 31, "03-22-2022", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 30, "03-22-2022", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 29, "03-22-2022", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 28, "03-22-2022", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 27, "03-22-2022", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 26, "03-21-2022", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 25, "03-21-2022", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 23, "03-21-2022", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlotResponse",
                columns: new[] { "TimeSlotId", "Date", "Taken", "Time" },
                values: new object[] { 91, "03-26-2022", false, "8:00 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSlotResponse");
        }
    }
}
