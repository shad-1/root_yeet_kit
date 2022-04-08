﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YeetCarAccidents.Data;

namespace YeetCarAccidents.Migrations.Crash
{
    [DbContext(typeof(CrashContext))]
    partial class CrashContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YeetCarAccidents.Models.Crash", b =>
                {
                    b.Property<int>("CrashId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CRASH_ID")
                        .HasColumnType("int");

                    b.Property<bool?>("Bicyclist")
                        .HasColumnName("BICYCLIST_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Commercial")
                        .HasColumnName("COMMERCIAL_MOTOR_VEH_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnName("CRASH_DATETIME")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("Distracted")
                        .HasColumnName("DISTRACTED_DRIVING")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("DomesticAnimal")
                        .HasColumnName("DOMESTIC_ANIMAL_RELATED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Drowsy")
                        .HasColumnName("DROWSY_DRIVING")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Dui")
                        .HasColumnName("DUI")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("ImproperRestraint")
                        .HasColumnName("IMPROPER_RESTRAINT")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Intersection")
                        .HasColumnName("INTERSECTION_RELATED")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationID")
                        .HasColumnName("LOCATION_ID")
                        .HasColumnType("int");

                    b.Property<bool?>("Motorcycle")
                        .HasColumnName("MOTORCYCLE_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Night")
                        .HasColumnName("NIGHT_DARK_CONDITION")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Older")
                        .HasColumnName("OLDER_DRIVER_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Pedestrian")
                        .HasColumnName("PEDESTRIAN_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("RoadwayDeparture")
                        .HasColumnName("ROADWAY_DEPARTURE")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Rollover")
                        .HasColumnName("OVERTURN_ROLLOVER")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Severity")
                        .HasColumnName("CRASH_SEVERITY_ID")
                        .HasColumnType("int");

                    b.Property<bool?>("SingleVehicle")
                        .HasColumnName("SINGLE_VEHICLE")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Teenage")
                        .HasColumnName("TEENAGE_DRIVER_INVOLVED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("Unrestrained")
                        .HasColumnName("UNRESTRAINED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("WildAnimal")
                        .HasColumnName("WILD_ANIMAL_RELATED")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("WorkZone")
                        .HasColumnName("WORK_ZONE_RELATED")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CrashId");

                    b.HasIndex("LocationID");

                    b.ToTable("Crashes");
                });

            modelBuilder.Entity("YeetCarAccidents.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LOCATION_ID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnName("CITY")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("County")
                        .HasColumnName("COUNTY_NAME")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float?>("Latitude")
                        .HasColumnName("LAT_UTM_Y")
                        .HasColumnType("float");

                    b.Property<float?>("Longitude")
                        .HasColumnName("LONG_UTM_X")
                        .HasColumnType("float");

                    b.Property<float?>("Milepoint")
                        .HasColumnName("MILEPOINT")
                        .HasColumnType("float");

                    b.Property<string>("RoadName")
                        .HasColumnName("MAIN_ROAD_NAME")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Route")
                        .HasColumnName("ROUTE")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("YeetCarAccidents.Models.Crash", b =>
                {
                    b.HasOne("YeetCarAccidents.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
