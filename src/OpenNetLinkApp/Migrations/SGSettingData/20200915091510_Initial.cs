﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenNetLinkApp.Migrations.SGSettingData
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_SG_SETTING_DATA",
                columns: table => new
                {
                    GROUPID = table.Column<int>(type: "INTEGER", nullable: false),
                    UID = table.Column<string>(type: "varchar(128)", nullable: true),
                    UPW = table.Column<string>(type: "varchar(128)", nullable: true),
                    APPRLINE = table.Column<string>(type: "varchar(2048)", nullable: true),
                    DELAYDISPLAYPW = table.Column<string>(type: "TEXT", nullable: true),
                    AUTOLOGINING = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SG_SETTING_DATA_GROUPID", x => x.GROUPID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_SG_SETTING_DATA");
        }
    }
}
