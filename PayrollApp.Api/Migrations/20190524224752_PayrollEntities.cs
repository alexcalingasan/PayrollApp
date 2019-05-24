using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollApp.Api.Migrations
{
    public partial class PayrollEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeNumber = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    EmploymentStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PayDay = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StaffSalary = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payslips",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PayrollId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payslips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payslips_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payslips_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalDeductions",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PayslipId = table.Column<int>(nullable: false),
                    PayrollId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalDeductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalDeductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalDeductions_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalDeductions_Payslips_PayslipId",
                        column: x => x.PayslipId,
                        principalTable: "Payslips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalPayments",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PayslipId = table.Column<int>(nullable: false),
                    PayrollId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalPayments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalPayments_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalPayments_Payslips_PayslipId",
                        column: x => x.PayslipId,
                        principalTable: "Payslips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deductions",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PayslipId = table.Column<int>(nullable: false),
                    PayrollId = table.Column<int>(nullable: false),
                    LateHour = table.Column<decimal>(nullable: true),
                    LateMinute = table.Column<decimal>(nullable: true),
                    Lates = table.Column<decimal>(nullable: true),
                    AbsentDay = table.Column<decimal>(nullable: true),
                    Absences = table.Column<decimal>(nullable: true),
                    SSS = table.Column<decimal>(nullable: true),
                    PhilHealth = table.Column<decimal>(nullable: true),
                    HDMF = table.Column<decimal>(nullable: true),
                    CashAdvance = table.Column<decimal>(nullable: true),
                    SSSLoan = table.Column<decimal>(nullable: true),
                    HDMFLoan = table.Column<decimal>(nullable: true),
                    WithholdingTax = table.Column<decimal>(nullable: true),
                    Total = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_Payslips_PayslipId",
                        column: x => x.PayslipId,
                        principalTable: "Payslips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalaryComponents",
                columns: table => new
                {
                    IsArchived = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PayslipId = table.Column<int>(nullable: false),
                    PayrollId = table.Column<int>(nullable: false),
                    SalaryRate = table.Column<decimal>(nullable: true),
                    DailyRate = table.Column<decimal>(nullable: true),
                    DailyCola = table.Column<decimal>(nullable: true),
                    OrdinaryDays = table.Column<decimal>(nullable: true),
                    RestDay = table.Column<decimal>(nullable: true),
                    SpecialHoliday = table.Column<decimal>(nullable: true),
                    RegularHoliday = table.Column<decimal>(nullable: true),
                    RestDaySpecialHoliday = table.Column<decimal>(nullable: true),
                    RestDayRegularHoliday = table.Column<decimal>(nullable: true),
                    OrdinaryDaysPay = table.Column<decimal>(nullable: true),
                    RestDayPay = table.Column<decimal>(nullable: true),
                    SpecialHolidayPay = table.Column<decimal>(nullable: true),
                    RegularHolidayPay = table.Column<decimal>(nullable: true),
                    RestDaySpecialHolidayPay = table.Column<decimal>(nullable: true),
                    RestDayRegularHolidayPay = table.Column<decimal>(nullable: true),
                    Total = table.Column<decimal>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_Payslips_PayslipId",
                        column: x => x.PayslipId,
                        principalTable: "Payslips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDeductions_EmployeeId",
                table: "AdditionalDeductions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDeductions_PayrollId",
                table: "AdditionalDeductions",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDeductions_PayslipId",
                table: "AdditionalDeductions",
                column: "PayslipId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalPayments_EmployeeId",
                table: "AdditionalPayments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalPayments_PayrollId",
                table: "AdditionalPayments",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalPayments_PayslipId",
                table: "AdditionalPayments",
                column: "PayslipId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_EmployeeId",
                table: "Deductions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_PayrollId",
                table: "Deductions",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_PayslipId",
                table: "Deductions",
                column: "PayslipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payslips_EmployeeId",
                table: "Payslips",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payslips_PayrollId",
                table: "Payslips",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_EmployeeId",
                table: "SalaryComponents",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_PayrollId",
                table: "SalaryComponents",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_PayslipId",
                table: "SalaryComponents",
                column: "PayslipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalDeductions");

            migrationBuilder.DropTable(
                name: "AdditionalPayments");

            migrationBuilder.DropTable(
                name: "Deductions");

            migrationBuilder.DropTable(
                name: "SalaryComponents");

            migrationBuilder.DropTable(
                name: "Payslips");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Payrolls");
        }
    }
}
