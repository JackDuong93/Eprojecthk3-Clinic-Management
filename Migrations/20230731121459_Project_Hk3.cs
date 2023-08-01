using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicManagement_hk3.Migrations
{
    public partial class Project_Hk3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrugCategory",
                columns: table => new
                {
                    CateId = table.Column<int>(type: "int", nullable: false),
                    CateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DrugCate__27638D14396DD6B1", x => x.CateId);
                });

            migrationBuilder.CreateTable(
                name: "MachineCategory",
                columns: table => new
                {
                    CateId = table.Column<int>(type: "int", nullable: false),
                    CateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MachineC__27638D147F6F94C6", x => x.CateId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Image = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Drug",
                columns: table => new
                {
                    DrugId = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DrugName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CateId = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Original = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Ingredients = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Warning = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UserManual = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NetWeight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug", x => x.DrugId);
                    table.ForeignKey(
                        name: "FK__Drug__CateId__300424B4",
                        column: x => x.CateId,
                        principalTable: "DrugCategory",
                        principalColumn: "CateId");
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MachineName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CateId = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Original = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Guarantee = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.MachineId);
                    table.ForeignKey(
                        name: "FK__Machine__CateId__2D27B809",
                        column: x => x.CateId,
                        principalTable: "MachineCategory",
                        principalColumn: "CateId");
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PassWord = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Accounts__1788CC4C1298D693", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Accounts__RoleId__267ABA7A",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EduId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Educatio__1FD9490E804A404E", x => x.EduId);
                    table.ForeignKey(
                        name: "FK__Education__UserI__4222D4EF",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    FbUser = table.Column<int>(type: "int", nullable: true),
                    FbInfo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    FbTime = table.Column<DateTime>(type: "date", nullable: true),
                    Reply = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    ReplyTime = table.Column<DateTime>(type: "date", nullable: true),
                    AccountUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK__Feedback__FbUser__4AB81AF0",
                        column: x => x.FbUser,
                        principalTable: "Accounts",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Feedback_Accounts_AccountUserId",
                        column: x => x.AccountUserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK__Order__UserId__32E0915F",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    SlotId = table.Column<int>(type: "int", nullable: false),
                    Import_date = table.Column<DateTime>(type: "date", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Storage__0A124AAF837CF8F5", x => x.SlotId);
                    table.ForeignKey(
                        name: "FK__Storage__UserId__3A81B327",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "EduDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    EduId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK__EduDetail__EduId__47DBAE45",
                        column: x => x.EduId,
                        principalTable: "Education",
                        principalColumn: "EduId");
                    table.ForeignKey(
                        name: "FK__EduDetail__Staff__46E78A0C",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: true),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK__OrderDeta__DrugI__35BCFE0A",
                        column: x => x.DrugId,
                        principalTable: "Drug",
                        principalColumn: "DrugId");
                    table.ForeignKey(
                        name: "FK__OrderDeta__Machi__36B12243",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "MachineId");
                    table.ForeignKey(
                        name: "FK__OrderDeta__Order__37A5467C",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "StorageDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SlotId = table.Column<int>(type: "int", nullable: true),
                    Import_date = table.Column<DateTime>(type: "date", nullable: true),
                    Expiry_date = table.Column<DateTime>(type: "date", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: true),
                    DrugId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StorageDe__DrugI__3D5E1FD2",
                        column: x => x.DrugId,
                        principalTable: "Drug",
                        principalColumn: "DrugId");
                    table.ForeignKey(
                        name: "FK__StorageDe__Machi__3E52440B",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "MachineId");
                    table.ForeignKey(
                        name: "FK__StorageDe__SlotI__3F466844",
                        column: x => x.SlotId,
                        principalTable: "Storage",
                        principalColumn: "SlotId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_CateId",
                table: "Drug",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserId",
                table: "Education",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EduDetail_EduId",
                table: "EduDetail",
                column: "EduId");

            migrationBuilder.CreateIndex(
                name: "IX_EduDetail_StaffId",
                table: "EduDetail",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_AccountUserId",
                table: "Feedback",
                column: "AccountUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_FbUser",
                table: "Feedback",
                column: "FbUser");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_CateId",
                table: "Machine",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_DrugId",
                table: "OrderDetail",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MachineId",
                table: "OrderDetail",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_UserId",
                table: "Storage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDetail_DrugId",
                table: "StorageDetail",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDetail_MachineId",
                table: "StorageDetail",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDetail_SlotId",
                table: "StorageDetail",
                column: "SlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EduDetail");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "StorageDetail");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Drug");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "DrugCategory");

            migrationBuilder.DropTable(
                name: "MachineCategory");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
