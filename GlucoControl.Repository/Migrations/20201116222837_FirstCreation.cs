using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlucoControl.Repository.Migrations
{
    public partial class FirstCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsulinTypes",
                columns: table => new
                {
                    InsulinTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                    InsulinId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    GenericName = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    Peak = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    InsulinTypeId = table.Column<int>(nullable: false)
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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lastname1 = table.Column<string>(nullable: true),
                    Lastname2 = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Controls",
                columns: table => new
                {
                    ControlId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ControlDate = table.Column<DateTime>(nullable: false),
                    GlucoseLevel = table.Column<int>(nullable: false),
                    ProvideInsulin = table.Column<bool>(nullable: true),
                    InsulinId = table.Column<int>(nullable: true),
                    InsulinAmount = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controls", x => x.ControlId);
                    table.ForeignKey(
                        name: "FK_Controls_Insulins_InsulinId",
                        column: x => x.InsulinId,
                        principalTable: "Insulins",
                        principalColumn: "InsulinId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Controls_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Controls_InsulinId",
                table: "Controls",
                column: "InsulinId");

            migrationBuilder.CreateIndex(
                name: "IX_Controls_UserId",
                table: "Controls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_InsulinTypeId",
                table: "Insulins",
                column: "InsulinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Controls");

            migrationBuilder.DropTable(
                name: "Insulins");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "InsulinTypes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
