using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testServerless.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AutoColor",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hex = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoDealer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoDealer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoDriveType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoDriveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoFuelType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoFuelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoSalon",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoSalon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoStatus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoTransmissionType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoTransmissionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoTransportType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoTransportType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoTSRegistration",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameFull = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoTSRegistration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nameseo = table.Column<string>(name: "Name_seo", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoBodyType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoTransportTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoBodyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoBodyType_AutoTransportType_AutoTransportTypeId",
                        column: x => x.AutoTransportTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoTransportType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AutoMake",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nameru = table.Column<string>(name: "Name_ru", type: "nvarchar(max)", nullable: false),
                    AutoTransportTypeId = table.Column<int>(type: "int", nullable: false),
                    Nameseo = table.Column<string>(name: "Name_seo", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoMake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoMake_AutoTransportType_AutoTransportTypeId",
                        column: x => x.AutoTransportTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoTransportType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nameseo = table.Column<string>(name: "Name_seo", type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Region_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "dbo",
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AutoModel",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nameru = table.Column<string>(name: "Name_ru", type: "nvarchar(max)", nullable: false),
                    AutoMakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoModel_AutoMake_AutoMakeId",
                        column: x => x.AutoMakeId,
                        principalSchema: "dbo",
                        principalTable: "AutoMake",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateAppearance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    TransportTypeId = table.Column<int>(type: "int", nullable: false),
                    BodyTypeId = table.Column<int>(type: "int", nullable: false),
                    MakeId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    YearOfIssue = table.Column<int>(type: "int", nullable: false),
                    Modification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TSRegistrationId = table.Column<int>(type: "int", nullable: false),
                    Probeg = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    PriceUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceUAH = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceUSDSearch = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceUAHSearch = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTorgAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsExchangeAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TransmissionTypeId = table.Column<int>(type: "int", nullable: true),
                    DriveTypeId = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: true),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    IsColorMetallic = table.Column<bool>(type: "bit", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: true),
                    FuelConsumptionCity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FuelConsumptionHighway = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FuelConsumptionMixed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EngineCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Power = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    CompletionJobId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Top = table.Column<int>(type: "int", nullable: false),
                    PlaceLat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceLng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InAuction = table.Column<bool>(type: "bit", nullable: false),
                    VipX = table.Column<int>(type: "int", nullable: true),
                    AddedVipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipDateExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionVipJobID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    AutoDealerId = table.Column<int>(type: "int", nullable: false),
                    IsAutoDealerAuto = table.Column<bool>(type: "bit", nullable: false),
                    SeoFriendlyUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AutoSalonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auto_AutoBodyType_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoBodyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoColor_ColorId",
                        column: x => x.ColorId,
                        principalSchema: "dbo",
                        principalTable: "AutoColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auto_AutoDealer_AutoDealerId",
                        column: x => x.AutoDealerId,
                        principalSchema: "dbo",
                        principalTable: "AutoDealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoDriveType_DriveTypeId",
                        column: x => x.DriveTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoDriveType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auto_AutoFuelType_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auto_AutoMake_MakeId",
                        column: x => x.MakeId,
                        principalSchema: "dbo",
                        principalTable: "AutoMake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoModel_ModelId",
                        column: x => x.ModelId,
                        principalSchema: "dbo",
                        principalTable: "AutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoSalon_AutoSalonId",
                        column: x => x.AutoSalonId,
                        principalSchema: "dbo",
                        principalTable: "AutoSalon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "dbo",
                        principalTable: "AutoStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoTSRegistration_TSRegistrationId",
                        column: x => x.TSRegistrationId,
                        principalSchema: "dbo",
                        principalTable: "AutoTSRegistration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_AutoTransmissionType_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoTransmissionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auto_AutoTransportType_TransportTypeId",
                        column: x => x.TransportTypeId,
                        principalSchema: "dbo",
                        principalTable: "AutoTransportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "dbo",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Auto_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_AutoDealerId",
                schema: "dbo",
                table: "Auto",
                column: "AutoDealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_AutoSalonId",
                schema: "dbo",
                table: "Auto",
                column: "AutoSalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_BodyTypeId",
                schema: "dbo",
                table: "Auto",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_CityId",
                schema: "dbo",
                table: "Auto",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_ColorId",
                schema: "dbo",
                table: "Auto",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_CurrencyId",
                schema: "dbo",
                table: "Auto",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_DriveTypeId",
                schema: "dbo",
                table: "Auto",
                column: "DriveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_FuelTypeId",
                schema: "dbo",
                table: "Auto",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_MakeId",
                schema: "dbo",
                table: "Auto",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_ModelId",
                schema: "dbo",
                table: "Auto",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_StatusId",
                schema: "dbo",
                table: "Auto",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_TransmissionTypeId",
                schema: "dbo",
                table: "Auto",
                column: "TransmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_TransportTypeId",
                schema: "dbo",
                table: "Auto",
                column: "TransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_TSRegistrationId",
                schema: "dbo",
                table: "Auto",
                column: "TSRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_UserId",
                schema: "dbo",
                table: "Auto",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoBodyType_AutoTransportTypeId",
                schema: "dbo",
                table: "AutoBodyType",
                column: "AutoTransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoMake_AutoTransportTypeId",
                schema: "dbo",
                table: "AutoMake",
                column: "AutoTransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModel_AutoMakeId",
                schema: "dbo",
                table: "AutoModel",
                column: "AutoMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_City_RegionId",
                schema: "dbo",
                table: "City",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                schema: "dbo",
                table: "User",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoBodyType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoColor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoDealer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoDriveType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoFuelType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoModel",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoSalon",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoTSRegistration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoTransmissionType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoMake",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "City",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AutoTransportType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Region",
                schema: "dbo");
        }
    }
}
