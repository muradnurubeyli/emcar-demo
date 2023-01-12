﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testServerless.Context;

#nullable disable

namespace testServerless.Migrations
{
    [DbContext(typeof(EmcarContext))]
    partial class EmcarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("testServerless.Models.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutoID")
                        .HasColumnType("int");

                    b.Property<string>("CompletionJobID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateStopped")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletionJobID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceUAHSearch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceUSDSearch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SeoFriendlyUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StartPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutoID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("StatusID");

                    b.ToTable("Auction", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AuctionBid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionID");

                    b.HasIndex("UserID");

                    b.ToTable("AuctionBid", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AuctionConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<string>("Connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionID");

                    b.HasIndex("UserID");

                    b.ToTable("AuctionConnection", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AuctionFavorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionID");

                    b.HasIndex("UserID");

                    b.ToTable("AuctionFavorite", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AuctionPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("uuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuctionID");

                    b.ToTable("AuctionPhoto", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AuctionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuctionStatus", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.Auto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AddedVipDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AutoDealerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("AutoSalonId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("BodyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("CompletionJobId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompletionVipJobID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateAppearance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateExpires")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DriveTypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("EngineCapacity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FuelConsumptionCity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FuelConsumptionHighway")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FuelConsumptionMixed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("InAuction")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAutoDealerAuto")
                        .HasColumnType("bit");

                    b.Property<bool>("IsColorMetallic")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExchangeAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTorgAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Modification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfDoors")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceLat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceLng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Power")
                        .HasColumnType("int");

                    b.Property<decimal?>("PriceUAH")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceUAHSearch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PriceUSD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceUSDSearch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Probeg")
                        .HasColumnType("int");

                    b.Property<string>("SeoFriendlyUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TSRegistrationId")
                        .HasColumnType("int");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.Property<int?>("TransmissionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TransportTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VipDateExpires")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VipX")
                        .HasColumnType("int");

                    b.Property<int>("YearOfIssue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutoDealerId");

                    b.HasIndex("AutoSalonId");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("DriveTypeId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TSRegistrationId");

                    b.HasIndex("TransmissionTypeId");

                    b.HasIndex("TransportTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Auto", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoBodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutoTransportTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutoTransportTypeId");

                    b.ToTable("AutoBodyType", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoColor", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoDealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoDealer", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoDriveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoDriveType", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoFuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoFuelType", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutoTransportTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_ru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_seo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutoTransportTypeId");

                    b.ToTable("AutoMake", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutoMakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_ru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutoMakeId");

                    b.ToTable("AutoModel", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoSalon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoSalon", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoStatus", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoTSRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFull")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoTSRegistration", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoTransmissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoTransmissionType", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.AutoTransportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AutoTransportType", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_seo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("City", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currency", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_seo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Region", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("User", "dbo");
                });

            modelBuilder.Entity("testServerless.Models.Auction", b =>
                {
                    b.HasOne("testServerless.Models.Auto", "Auto")
                        .WithMany("Auctions")
                        .HasForeignKey("AutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.Currency", "Currency")
                        .WithMany("Auctions")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AuctionStatus", "AuctionStatus")
                        .WithMany("Auctions")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuctionStatus");

                    b.Navigation("Auto");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("testServerless.Models.AuctionBid", b =>
                {
                    b.HasOne("testServerless.Models.Auction", "Auction")
                        .WithMany("AuctionBids")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.User", "User")
                        .WithMany("AuctionBids")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("testServerless.Models.AuctionConnection", b =>
                {
                    b.HasOne("testServerless.Models.Auction", "Auction")
                        .WithMany("AuctionConnections")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.User", "User")
                        .WithMany("AuctionConnections")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("testServerless.Models.AuctionFavorite", b =>
                {
                    b.HasOne("testServerless.Models.Auction", "Auction")
                        .WithMany("AuctionFavorites")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.User", "User")
                        .WithMany("AuctionFavorites")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("testServerless.Models.AuctionPhoto", b =>
                {
                    b.HasOne("testServerless.Models.Auction", "Auction")
                        .WithMany("AuctionPhotos")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("testServerless.Models.Auto", b =>
                {
                    b.HasOne("testServerless.Models.AutoDealer", "AutoDealer")
                        .WithMany("Autos")
                        .HasForeignKey("AutoDealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoSalon", "AutoSalon")
                        .WithMany("Autos")
                        .HasForeignKey("AutoSalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoBodyType", "AutoBodyType")
                        .WithMany("Autos")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.City", "City")
                        .WithMany("Autos")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoColor", "AutoColor")
                        .WithMany("Autos")
                        .HasForeignKey("ColorId");

                    b.HasOne("testServerless.Models.Currency", "Currency")
                        .WithMany("Autos")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoDriveType", "AutoDriveType")
                        .WithMany("Autos")
                        .HasForeignKey("DriveTypeId");

                    b.HasOne("testServerless.Models.AutoFuelType", "AutoFuelType")
                        .WithMany("Autos")
                        .HasForeignKey("FuelTypeId");

                    b.HasOne("testServerless.Models.AutoMake", "AutoMake")
                        .WithMany("Autos")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoModel", "AutoModel")
                        .WithMany("Autos")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoStatus", "AutoStatus")
                        .WithMany("Autos")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoTSRegistration", "AutoTSRegistration")
                        .WithMany("Autos")
                        .HasForeignKey("TSRegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.AutoTransmissionType", "AutoTransmissionType")
                        .WithMany("Autos")
                        .HasForeignKey("TransmissionTypeId");

                    b.HasOne("testServerless.Models.AutoTransportType", "AutoTransportType")
                        .WithMany("Autos")
                        .HasForeignKey("TransportTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testServerless.Models.User", "User")
                        .WithMany("Autos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutoBodyType");

                    b.Navigation("AutoColor");

                    b.Navigation("AutoDealer");

                    b.Navigation("AutoDriveType");

                    b.Navigation("AutoFuelType");

                    b.Navigation("AutoMake");

                    b.Navigation("AutoModel");

                    b.Navigation("AutoSalon");

                    b.Navigation("AutoStatus");

                    b.Navigation("AutoTSRegistration");

                    b.Navigation("AutoTransmissionType");

                    b.Navigation("AutoTransportType");

                    b.Navigation("City");

                    b.Navigation("Currency");

                    b.Navigation("User");
                });

            modelBuilder.Entity("testServerless.Models.AutoBodyType", b =>
                {
                    b.HasOne("testServerless.Models.AutoTransportType", null)
                        .WithMany("AutoBodyTypes")
                        .HasForeignKey("AutoTransportTypeId");
                });

            modelBuilder.Entity("testServerless.Models.AutoMake", b =>
                {
                    b.HasOne("testServerless.Models.AutoTransportType", "AutoTransportType")
                        .WithMany("AutoMakes")
                        .HasForeignKey("AutoTransportTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AutoTransportType");
                });

            modelBuilder.Entity("testServerless.Models.AutoModel", b =>
                {
                    b.HasOne("testServerless.Models.AutoMake", "AutoMake")
                        .WithMany("AutoModels")
                        .HasForeignKey("AutoMakeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AutoMake");
                });

            modelBuilder.Entity("testServerless.Models.City", b =>
                {
                    b.HasOne("testServerless.Models.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("testServerless.Models.User", b =>
                {
                    b.HasOne("testServerless.Models.City", null)
                        .WithMany("Users")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("testServerless.Models.Auction", b =>
                {
                    b.Navigation("AuctionBids");

                    b.Navigation("AuctionConnections");

                    b.Navigation("AuctionFavorites");

                    b.Navigation("AuctionPhotos");
                });

            modelBuilder.Entity("testServerless.Models.AuctionStatus", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("testServerless.Models.Auto", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("testServerless.Models.AutoBodyType", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoColor", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoDealer", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoDriveType", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoFuelType", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoMake", b =>
                {
                    b.Navigation("AutoModels");

                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoModel", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoSalon", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoStatus", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoTSRegistration", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoTransmissionType", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.AutoTransportType", b =>
                {
                    b.Navigation("AutoBodyTypes");

                    b.Navigation("AutoMakes");

                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.City", b =>
                {
                    b.Navigation("Autos");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("testServerless.Models.Currency", b =>
                {
                    b.Navigation("Auctions");

                    b.Navigation("Autos");
                });

            modelBuilder.Entity("testServerless.Models.Region", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("testServerless.Models.User", b =>
                {
                    b.Navigation("AuctionBids");

                    b.Navigation("AuctionConnections");

                    b.Navigation("AuctionFavorites");

                    b.Navigation("Autos");
                });
#pragma warning restore 612, 618
        }
    }
}
