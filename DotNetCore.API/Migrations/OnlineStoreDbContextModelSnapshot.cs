﻿// <auto-generated />
using System;
using DotNetCore.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetCore.API.Migrations
{
    [DbContext(typeof(OnlineStoreDbContext))]
    partial class OnlineStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNetCore.API.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DotNetCore.API.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DotNetCore.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c09933a-5c31-4a21-9a39-ac277f26ba2d"),
                            Code = "GP",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4793),
                            Description = "Gauteng Province",
                            Name = "Gauteng",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4794)
                        },
                        new
                        {
                            Id = new Guid("f97bd724-d791-49eb-b573-9677f7c954aa"),
                            Code = "GP",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4797),
                            Description = "KwaZulu-Natal",
                            Name = "KwaZulu-Natal",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4797)
                        },
                        new
                        {
                            Id = new Guid("54d4f86d-3e8e-4ecb-9bc8-b25371e85c7d"),
                            Code = "EC",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4807),
                            Description = "Eastern Cape",
                            Name = "Eastern Cape",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4807)
                        },
                        new
                        {
                            Id = new Guid("1cb39730-ba8b-4192-9cb3-f904bf08ce36"),
                            Code = "FS",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4809),
                            Description = "Free State",
                            Name = "Free State",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4809)
                        },
                        new
                        {
                            Id = new Guid("2ad69f04-3f02-4b63-a8b0-a56b0ac57ed2"),
                            Code = "LP",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4810),
                            Description = "Limpopo",
                            Name = "Limpopo",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4811)
                        },
                        new
                        {
                            Id = new Guid("95f410ba-df39-40bc-8246-e380c2374747"),
                            Code = "MP",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4812),
                            Description = "Mpumalanga",
                            Name = "Mpumalanga",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4812)
                        },
                        new
                        {
                            Id = new Guid("80c2cef2-fe86-4853-8388-a5e21868cfee"),
                            Code = "NW",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4814),
                            Description = "North West",
                            Name = "North West",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4814)
                        },
                        new
                        {
                            Id = new Guid("e663f227-29b6-45f7-8d29-d113323364c0"),
                            Code = "NC",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4816),
                            Description = "Northern Cape",
                            Name = "Northern Cape",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4816)
                        },
                        new
                        {
                            Id = new Guid("ce4d77f5-924b-45d5-bbec-783203cd7381"),
                            Code = "WC",
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4817),
                            Description = "Western Cape",
                            Name = "Western Cape",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4817)
                        });
                });

            modelBuilder.Entity("DotNetCore.API.Models.Domain.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VendorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppiers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26fd66b3-8a2f-4315-b26f-b748f82f2149"),
                            CreatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4924),
                            IsActive = 1,
                            Name = "The Prepaid Company",
                            UpdatedDate = new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4925),
                            VendorCode = "TPC"
                        });
                });

            modelBuilder.Entity("DotNetCore.API.Models.Domain.Product", b =>
                {
                    b.HasOne("DotNetCore.API.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetCore.API.Models.Domain.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
