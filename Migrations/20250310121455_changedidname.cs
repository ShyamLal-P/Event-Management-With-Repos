using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagementSystemRepos.Migrations
{
    /// <inheritdoc />
    public partial class changedidname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NotificationId",
                table: "Notifications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FeedBackId",
                table: "Feedbacks",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notifications",
                newName: "NotificationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Feedbacks",
                newName: "FeedBackId");
        }
    }
}
