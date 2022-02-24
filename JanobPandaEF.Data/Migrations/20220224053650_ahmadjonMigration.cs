using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JanobPandaEF.Data.Migrations
{
    public partial class ahmadjonMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "universities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    subject_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_groups_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    university_id = table.Column<int>(type: "integer", nullable: false),
                    group_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                    table.ForeignKey(
                        name: "FK_students_groups_group_id",
                        column: x => x.group_id,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_universities_university_id",
                        column: x => x.university_id,
                        principalTable: "universities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, ".NET" },
                    { 2, "Java" },
                    { 3, "Go" }
                });

            migrationBuilder.InsertData(
                table: "universities",
                columns: new[] { "id", "address", "level", "name" },
                values: new object[,]
                {
                    { 1, "Tashkent", 1, "TUIT" },
                    { 2, "Tashkent", 2, "WIUT" }
                });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "id", "name", "subject_id" },
                values: new object[,]
                {
                    { 1, "dotNET #1", 1 },
                    { 2, "Java #1", 2 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "fullname", "group_id", "university_id" },
                values: new object[,]
                {
                    { 1, "Ahmadjon Sirojiddinov", 1, 2 },
                    { 3, "Abbos Haydarov", 1, 1 },
                    { 2, "Muhammadabdulloh Komilov", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_groups_subject_id",
                table: "groups",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_group_id",
                table: "students",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_university_id",
                table: "students",
                column: "university_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "universities");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
