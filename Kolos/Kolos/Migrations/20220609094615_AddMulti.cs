using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos.Migrations
{
    public partial class AddMulti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicianTrack",
                columns: table => new
                {
                    MusicianIdMusician = table.Column<int>(type: "int", nullable: false),
                    TrackIdTrack = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianTrack", x => new { x.MusicianIdMusician, x.TrackIdTrack });
                    table.ForeignKey(
                        name: "FK_MusicianTrack_Musician_MusicianIdMusician",
                        column: x => x.MusicianIdMusician,
                        principalTable: "Musician",
                        principalColumn: "IdMusician",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianTrack_Track_TrackIdTrack",
                        column: x => x.TrackIdTrack,
                        principalTable: "Track",
                        principalColumn: "IdTrack",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianTrack_TrackIdTrack",
                table: "MusicianTrack",
                column: "TrackIdTrack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianTrack");
        }
    }
}
