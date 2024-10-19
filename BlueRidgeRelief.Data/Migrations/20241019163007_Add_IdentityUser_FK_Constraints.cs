using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueRidgeRelief.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_IdentityUser_FK_Constraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Needs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "CustomUserDetails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Needs_IdentityUserId",
                table: "Needs",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomUserDetails_IdentityUserId",
                table: "CustomUserDetails",
                column: "IdentityUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomUserDetails_AspNetUsers_IdentityUserId",
                table: "CustomUserDetails",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Needs_AspNetUsers_IdentityUserId",
                table: "Needs",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomUserDetails_AspNetUsers_IdentityUserId",
                table: "CustomUserDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Needs_AspNetUsers_IdentityUserId",
                table: "Needs");

            migrationBuilder.DropIndex(
                name: "IX_Needs_IdentityUserId",
                table: "Needs");

            migrationBuilder.DropIndex(
                name: "IX_CustomUserDetails_IdentityUserId",
                table: "CustomUserDetails");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Needs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "CustomUserDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
