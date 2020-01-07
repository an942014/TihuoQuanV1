﻿// <auto-generated />
using System;
using BangBangFuli.H5.API.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BangBangFuli.H5.API.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(CouponSystemDBContext))]
    [Migration("20191201073203_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchCode");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvaliableCount");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("TotalCount");

                    b.Property<DateTime>("ValidityDate");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Contactor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeliveryNumber");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ProductCount")
                        .HasMaxLength(10);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoPath");

                    b.Property<int>("ProductInformationId");

                    b.HasKey("Id");

                    b.HasIndex("ProductInformationId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchId");

                    b.Property<int>("Class1");

                    b.Property<int>("Class2");

                    b.Property<string>("Description");

                    b.Property<bool>("IsInStock");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductInformations");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("SupplierName");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.OrderDetail", b =>
                {
                    b.HasOne("BangBangFuli.H5.API.Core.Entities.Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BangBangFuli.H5.API.Core.Entities.ProductDetail", b =>
                {
                    b.HasOne("BangBangFuli.H5.API.Core.Entities.ProductInformation")
                        .WithMany("Details")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
