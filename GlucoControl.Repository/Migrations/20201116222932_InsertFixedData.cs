using Microsoft.EntityFrameworkCore.Migrations;

namespace GlucoControl.Repository.Migrations
{
    public partial class InsertFixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsulinTypes",
                columns: new[] { "InsulinTypeId", "Description" },
                values: new object[,]
                {
                    { 1, "Ultrarápidas" },
                    { 2, "Rápidas" },
                    { 3, "Intermedias" },
                    { 4, "Prolongadas" }
                }
            );


            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Usuario" }
                }
            );


            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Lastname1", "Lastname2", "Age", "Height", "Weight", "RoleId", "Username", "Password" },
                values: new object[,]
                {
                    { 1, "Alexis", "Ciorraga", "Rodriguez", "35", 0,0,1, "aciorraga", "12.DiC.1985" },
                    { 2, "Antonia", "Rodriguez", "Perez", "0", 0,0, 2, "arodriguez", "" },
                    { 3, "Benito", "Ciorraga", "Castro", "0", 0,0,2, "bciorraga", "" }
                }
            );


            migrationBuilder.InsertData(
                table: "Insulins",
                columns: new[] { "InsulinId", "Brand", "GenericName", "StartTime", "Peak", "Duration", "InsulinTypeId" },
                values: new object[,]
                {
                    // Ultrarápidas
                    { 1, "Fiasp", "Fiasp FlexTouch", "10", "120", "240", 1 },
                    { 2, "NovoRapid", "NovoRapid Flexpen", "15", "120", "240", 1 },
                    { 3, "Apidra", "Apidra Solostar", "15", "120", "240", 1 },
                    { 4, "Humalog", "Humalog KwikPen", "15", "120", "240", 1 },
                    { 5, "Humalog", "Humalog Junior KwikPen", "15", "120", "240", 1 },
                    { 6, "Humalog", "Humalog KwikPen 200", "15", "120", "240", 1 },

                    // Rápidas
                    { 7, "Actrapid Humulina Regular", "Actrapid Innolet", "30", "240", "480", 2 },

                    // Intermedias
                    { 8, "Insulatard", "Insulatard FlexPen", "120", "480", "720", 3 },
                    { 9, "Humulina NPH", "Humulina NPH KwikPen", "120", "480", "720", 3 },

                    // Prolongadas
                    { 10, "Abasaglar", "Abasaglar KwikPen", "120", "0", "1440", 4 },
                    { 11, "Lantus", "Lantus Solostar", "120", "0", "1440", 4 },
                    { 12, "Toujeo", "Toujeo Solostar", "120", "0", "2160", 4 },
                    { 13, "Levemir", "Levemir FlexPen", "120", "0", "1080", 4 },
                    { 14, "Levemir", "Levemir Innolet", "120", "0", "1080", 4 },

                    { 15, "Tresiba", "Tresiba FlexTouch 100", "120", "0", "2520", 4 },
                    { 16, "Tresiba", "Tresiba FlexTouch 200", "120", "0", "2520", 4 }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
