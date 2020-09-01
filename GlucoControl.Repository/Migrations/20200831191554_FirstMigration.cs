using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GlucoControl.Repository.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsulinTypes",
                columns: table => new
                {
                    InsulinTypeId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulinTypes", x => x.InsulinTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Insulins",
                columns: table => new
                {
                    InsulinId = table.Column<Guid>(nullable: false),
                    InsulinTypeId = table.Column<Guid>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    GenericName = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    Peak = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insulins", x => x.InsulinId);
                    table.ForeignKey(
                        name: "FK_Insulins_InsulinTypes_InsulinTypeId",
                        column: x => x.InsulinTypeId,
                        principalTable: "InsulinTypes",
                        principalColumn: "InsulinTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Lastname1 = table.Column<string>(nullable: true),
                    Lastname2 = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_InsulinTypeId",
                table: "Insulins",
                column: "InsulinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId1",
                table: "User",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insulins");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "InsulinTypes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}