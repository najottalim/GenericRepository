using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JanobPandaEF.Data.Migrations
{
    public partial class nafisaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_subjects_subject_id",
                table: "groups");

            migrationBuilder.DropForeignKey(
                name: "FK_students_groups_group_id",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_universities_university_id",
                table: "students");

            migrationBuilder.DropTable(
                name: "StudentDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_universities",
                table: "universities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subjects",
                table: "subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_groups",
                table: "groups");

            migrationBuilder.RenameTable(
                name: "universities",
                newName: "Universities");

            migrationBuilder.RenameTable(
                name: "subjects",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "groups",
                newName: "Groups");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Universities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "level",
                table: "Universities",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Universities",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Universities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Subjects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Subjects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fullname",
                table: "Students",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "university_id",
                table: "Students",
                newName: "UniversityId");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_students_university_id",
                table: "Students",
                newName: "IX_Students_UniversityId");

            migrationBuilder.RenameIndex(
                name: "IX_students_group_id",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Groups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "Groups",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_groups_subject_id",
                table: "Groups",
                newName: "IX_Groups_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universities",
                table: "Universities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Subjects_SubjectId",
                table: "Groups",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Subjects_SubjectId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Universities",
                table: "Universities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Universities",
                newName: "universities");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "subjects");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "groups");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "universities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "universities",
                newName: "level");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "universities",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "universities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "subjects",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "subjects",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "students",
                newName: "fullname");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "students",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UniversityId",
                table: "students",
                newName: "university_id");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "students",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_UniversityId",
                table: "students",
                newName: "IX_students_university_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "students",
                newName: "IX_students_group_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "groups",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "groups",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "groups",
                newName: "subject_id");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_SubjectId",
                table: "groups",
                newName: "IX_groups_subject_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_universities",
                table: "universities",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subjects",
                table: "subjects",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_groups",
                table: "groups",
                column: "id");

            migrationBuilder.CreateTable(
                name: "StudentDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullname = table.Column<string>(type: "text", nullable: true),
                    group_name = table.Column<string>(type: "text", nullable: true),
                    subject_name = table.Column<string>(type: "text", nullable: true),
                    university_name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDatas", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_groups_subjects_subject_id",
                table: "groups",
                column: "subject_id",
                principalTable: "subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_groups_group_id",
                table: "students",
                column: "group_id",
                principalTable: "groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_universities_university_id",
                table: "students",
                column: "university_id",
                principalTable: "universities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
