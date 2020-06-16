using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuyenMucs",
                columns: table => new
                {
                    CateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateName = table.Column<string>(nullable: false),
                    CateTT = table.Column<int>(nullable: false),
                    CateHide = table.Column<int>(nullable: false, defaultValue: 48)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenMucs", x => x.CateID);
                });

            migrationBuilder.CreateTable(
                name: "Dems",
                columns: table => new
                {
                    CountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dems", x => x.CountID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTins",
                columns: table => new
                {
                    LTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LTName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    LTThuTu = table.Column<int>(nullable: false),
                    LTHide = table.Column<int>(nullable: false),
                    CateID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTins", x => x.LTID);
                });

            migrationBuilder.CreateTable(
                name: "TinTucs",
                columns: table => new
                {
                    TinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    TomTat = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NoiDung = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    UrlImg = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    SoLanXem = table.Column<int>(nullable: false),
                    KeyWord = table.Column<string>(nullable: true),
                    TinNoiBat = table.Column<int>(nullable: false),
                    LTID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTucs", x => x.TinID);
                    table.ForeignKey(
                        name: "FK_TinTucs_LoaiTins_LTID",
                        column: x => x.LTID,
                        principalTable: "LoaiTins",
                        principalColumn: "LTID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TinTucs_LTID",
                table: "TinTucs",
                column: "LTID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenMucs");

            migrationBuilder.DropTable(
                name: "Dems");

            migrationBuilder.DropTable(
                name: "TinTucs");

            migrationBuilder.DropTable(
                name: "LoaiTins");
        }
    }
}
