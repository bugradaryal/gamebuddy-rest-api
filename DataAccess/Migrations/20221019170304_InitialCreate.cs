using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllGames",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllGames", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true, defaultValue: "Hello i am new to this website..."),
                    password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    username = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "My_Games",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    game_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My_Games", x => x.id);
                    table.ForeignKey(
                        name: "FK_My_Games_AllGames_game_id",
                        column: x => x.game_id,
                        principalTable: "AllGames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_My_Games_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameAccounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    my_game_id = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValue: "Unknown"),
                    game_nick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    info = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValue: "There is no information"),
                    server = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameAccounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_GameAccounts_My_Games_my_game_id",
                        column: x => x.my_game_id,
                        principalTable: "My_Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameAccounts_my_game_id",
                table: "GameAccounts",
                column: "my_game_id");

            migrationBuilder.CreateIndex(
                name: "IX_My_Games_game_id",
                table: "My_Games",
                column: "game_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_My_Games_user_id",
                table: "My_Games",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameAccounts");

            migrationBuilder.DropTable(
                name: "My_Games");

            migrationBuilder.DropTable(
                name: "AllGames");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
