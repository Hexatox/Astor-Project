using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f7efc1-306d-43c9-b1c6-eb131aad85c5", new DateTime(2024, 5, 13, 9, 59, 43, 49, DateTimeKind.Local).AddTicks(2087), "AQAAAAIAAYagAAAAEKBYKYmTrxqJKwlBIvY0Ir9YmaiUyPNWYCRTzRDGD1tfZsOwZwG/MVAO1iMVQfDc7A==", "03b08b8e-320c-49c7-8bd4-a986cd28d4c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d35e3ea-fb63-482f-b7f7-daf830fc6285",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0127c311-349f-4d34-a990-cf8ae9d10f9d", new DateTime(2024, 5, 13, 9, 59, 42, 899, DateTimeKind.Local).AddTicks(8691), "AQAAAAIAAYagAAAAEI3q+/hqcqxyJEUbj7/zfmPFKvBK0Ili8EP15xaPYikzcXZzQM7wCovr2ZXBcDAr3g==", "35abf95f-c535-4265-98fd-70ef1b2a33e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b178fae6-61f1-4b54-9480-021cf483faf8",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8de3ef00-f82b-4e59-8859-3218d1942421", new DateTime(2024, 5, 13, 9, 59, 43, 197, DateTimeKind.Local).AddTicks(3832), "AQAAAAIAAYagAAAAEHNNfb3uyxiCICQTyNdNEd1Cr9LapnBlW17xrQTe/jCUc0Y4t6GmmxsEGjIapVRhEg==", "c6c4215b-b695-4030-b58a-c09c59a2ab64" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60b5ca0e-6fe3-4430-8f17-4c178ff81991", new DateTime(2024, 5, 7, 0, 40, 55, 156, DateTimeKind.Local).AddTicks(4550), "AQAAAAIAAYagAAAAEFb3+P0qxhFNNW7u5foWedn3FCYuwwQGphUIpVp6s1qa/O7DKHg+eVDzL5Qk2L4mSg==", "4d65f0bc-5935-4c47-a7ec-b9ad709184ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d35e3ea-fb63-482f-b7f7-daf830fc6285",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82fbff7-2988-4bfc-842b-1b8450e694fa", new DateTime(2024, 5, 7, 0, 40, 55, 97, DateTimeKind.Local).AddTicks(2052), "AQAAAAIAAYagAAAAEK0PNrBmgogfBAEKZAlMomzlenw81Cz+4YJOayOQQt5+5F8a8jNiAISSxyV7SkG5kQ==", "6f1986df-6808-459e-8a0c-afc1f30639fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b178fae6-61f1-4b54-9480-021cf483faf8",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1df1f047-deba-4bc0-8790-2c19604c592c", new DateTime(2024, 5, 7, 0, 40, 55, 214, DateTimeKind.Local).AddTicks(3689), "AQAAAAIAAYagAAAAEIN8+i40mmwOTP4sojBTzoM2oNHcePRkT2iRFL2qzeALoB1+t/1vqtBd/u8r2W1mww==", "0ea43905-a82e-4069-adf0-29d152b99372" });
        }
    }
}
