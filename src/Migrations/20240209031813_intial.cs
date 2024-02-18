using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    BidListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    BidQuantity = table.Column<double>(nullable: false),
                    AskQuantity = table.Column<double>(nullable: false),
                    Bid = table.Column<double>(nullable: false),
                    Ask = table.Column<double>(nullable: false),
                    Benchmark = table.Column<string>(nullable: true),
                    BidListDate = table.Column<DateTime>(nullable: false),
                    Commentary = table.Column<string>(nullable: true),
                    Security = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Trader = table.Column<string>(nullable: true),
                    Book = table.Column<string>(nullable: true),
                    CreationName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RevisionName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<DateTime>(nullable: false),
                    DealName = table.Column<string>(nullable: true),
                    DealType = table.Column<string>(nullable: true),
                    SourceListId = table.Column<string>(nullable: true),
                    Side = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.BidListId);
                });

            migrationBuilder.CreateTable(
                name: "CurvePoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurveId = table.Column<int>(nullable: false),
                    AsOfDate = table.Column<DateTime>(nullable: false),
                    Term = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurvePoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MoodysRating = table.Column<string>(nullable: true),
                    SandPRating = table.Column<string>(nullable: true),
                    FitchRating = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Json = table.Column<string>(nullable: true),
                    Template = table.Column<string>(nullable: true),
                    SqlStr = table.Column<string>(nullable: true),
                    SqlPart = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    TradeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account = table.Column<string>(nullable: true),
                    BuyQuantity = table.Column<double>(nullable: false),
                    SellQuantity = table.Column<double>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    Benchmark = table.Column<string>(nullable: true),
                    TradeDate = table.Column<DateTime>(nullable: false),
                    Security = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Trader = table.Column<string>(nullable: true),
                    Book = table.Column<string>(nullable: true),
                    CreationName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RevisionName = table.Column<string>(nullable: true),
                    RevisionDate = table.Column<DateTime>(nullable: false),
                    DealName = table.Column<string>(nullable: true),
                    DealType = table.Column<string>(nullable: true),
                    SourceListId = table.Column<string>(nullable: true),
                    Side = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.TradeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "CurvePoints");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Trades");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
