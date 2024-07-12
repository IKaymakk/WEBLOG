using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Contacts",
                newName: "ContactUserName");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Contacts",
                newName: "ContactSubject");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Contacts",
                newName: "ContactStatus");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Contacts",
                newName: "ContactMail");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Contacts",
                newName: "ContactDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Contacts",
                newName: "ContactContent");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Comments",
                newName: "CommentUserName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Comments",
                newName: "CommentTitle");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Comments",
                newName: "CommentStatus");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Comments",
                newName: "CommentDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comments",
                newName: "CommentContent");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Categories",
                newName: "CategoryStatus");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "CategoryDescription");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blogs",
                newName: "BlogTitle");

            migrationBuilder.RenameColumn(
                name: "ThumbnailImage",
                table: "Blogs",
                newName: "BlogThumbnailImage");

            migrationBuilder.RenameColumn(
                name: "Statu",
                table: "Blogs",
                newName: "BlogStatus");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Blogs",
                newName: "BlogImage");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Blogs",
                newName: "BlogDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Blogs",
                newName: "BlogContent");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Authors",
                newName: "AuthorStatus");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Authors",
                newName: "AuthorPassword");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "AuthorName");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Authors",
                newName: "AuthorMail");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Authors",
                newName: "AuthorImage");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "Authors",
                newName: "AuthorAbout");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Abouts",
                newName: "AboutStatus");

            migrationBuilder.RenameColumn(
                name: "MapLocation",
                table: "Abouts",
                newName: "AboutMapLocation");

            migrationBuilder.RenameColumn(
                name: "Image2",
                table: "Abouts",
                newName: "AboutImage2");

            migrationBuilder.RenameColumn(
                name: "Image1",
                table: "Abouts",
                newName: "AboutImage1");

            migrationBuilder.RenameColumn(
                name: "Details2",
                table: "Abouts",
                newName: "AboutDetails2");

            migrationBuilder.RenameColumn(
                name: "Details1",
                table: "Abouts",
                newName: "AboutDetails1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactUserName",
                table: "Contacts",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "ContactSubject",
                table: "Contacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "ContactStatus",
                table: "Contacts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ContactMail",
                table: "Contacts",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "ContactDate",
                table: "Contacts",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ContactContent",
                table: "Contacts",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "CommentUserName",
                table: "Comments",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "CommentTitle",
                table: "Comments",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CommentStatus",
                table: "Comments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "CommentDate",
                table: "Comments",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CommentContent",
                table: "Comments",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "CategoryStatus",
                table: "Categories",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "BlogTitle",
                table: "Blogs",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "BlogThumbnailImage",
                table: "Blogs",
                newName: "ThumbnailImage");

            migrationBuilder.RenameColumn(
                name: "BlogStatus",
                table: "Blogs",
                newName: "Statu");

            migrationBuilder.RenameColumn(
                name: "BlogImage",
                table: "Blogs",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "BlogDate",
                table: "Blogs",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "BlogContent",
                table: "Blogs",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "AuthorStatus",
                table: "Authors",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AuthorPassword",
                table: "Authors",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Authors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AuthorMail",
                table: "Authors",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "AuthorImage",
                table: "Authors",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "AuthorAbout",
                table: "Authors",
                newName: "About");

            migrationBuilder.RenameColumn(
                name: "AboutStatus",
                table: "Abouts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AboutMapLocation",
                table: "Abouts",
                newName: "MapLocation");

            migrationBuilder.RenameColumn(
                name: "AboutImage2",
                table: "Abouts",
                newName: "Image2");

            migrationBuilder.RenameColumn(
                name: "AboutImage1",
                table: "Abouts",
                newName: "Image1");

            migrationBuilder.RenameColumn(
                name: "AboutDetails2",
                table: "Abouts",
                newName: "Details2");

            migrationBuilder.RenameColumn(
                name: "AboutDetails1",
                table: "Abouts",
                newName: "Details1");
        }
    }
}
