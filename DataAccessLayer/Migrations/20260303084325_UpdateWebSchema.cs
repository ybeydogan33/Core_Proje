using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWebSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "SocialMedias",
                newName: "IconClass");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Portfolios",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ImageUrl2",
                table: "Portfolios",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Messages",
                newName: "IsRead");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Messages",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Messages",
                newName: "SenderName");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Features",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Experiences",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Experiences",
                newName: "LogoUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Experiences",
                newName: "DateRange");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Experiences",
                newName: "Company");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Contacts",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "SenderEmail",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Features",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Features",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", nullable: false),
                    CertificateUrl = table.Column<string>(type: "TEXT", nullable: false),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateID);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Institution = table.Column<string>(type: "TEXT", nullable: false),
                    DateRange = table.Column<string>(type: "TEXT", nullable: false),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropColumn(
                name: "SenderEmail",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "IconClass",
                table: "SocialMedias",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Portfolios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Portfolios",
                newName: "ImageUrl2");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Messages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "Messages",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "IsRead",
                table: "Messages",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Features",
                newName: "Header");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Experiences",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "Experiences",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "DateRange",
                table: "Experiences",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Experiences",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Contacts",
                newName: "Mail");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientName = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }
    }
}
