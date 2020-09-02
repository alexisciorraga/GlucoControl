using Microsoft.EntityFrameworkCore.Migrations;

namespace GlucoControl.Repository.Migrations
{
    public partial class InsertFixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region [ Insert fixed data ]

            #region [ InsulinType ]

            migrationBuilder.InsertData(
                table: "InsulinTypes",
                columns: new[] { "Description" },
                values: new object[] { "Ultrarápidas" }
                );

            migrationBuilder.InsertData(
                table: "InsulinTypes",
                columns: new[] { "Description" },
                values: new object[] { "Rápidas" }
                );

            migrationBuilder.InsertData(
                table: "InsulinTypes",
                columns: new[] { "Description" },
                values: new object[] { "Intermedias" }
                );

            migrationBuilder.InsertData(
                table: "InsulinTypes",
                columns: new[] { "Description" },
                values: new object[] { "Prolongadas" }
                );

            #endregion

            #region [ Role ]

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Description" },
                values: new object[] { "Admin" }
                );

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Description" },
                values: new object[] { "User" }
                );

            #endregion

            #endregion
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
