using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CateID",
                table: "LoaiTins",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
            //migrationBuilder.InsertData(
            //    table: "AppRoles",
            //    columns:new [] {"Id","ConcurrencyStamp"}
            //    );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CateID",
                table: "LoaiTins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

