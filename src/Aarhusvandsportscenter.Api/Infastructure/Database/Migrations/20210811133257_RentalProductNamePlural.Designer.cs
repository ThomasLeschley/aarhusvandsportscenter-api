﻿// <auto-generated />
using System;
using Aarhusvandsportscenter.Api.Infastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aarhusvandsportscenter.Api.Infastructure.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210811133257_RentalProductNamePlural")]
    partial class RentalProductNamePlural
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.AccountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ResetPasswordToken")
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("ContentPages");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageImageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContentPageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContentPageId");

                    b.ToTable("ContentPageImages");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageSectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<int>("ContentPageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContentPageId");

                    b.HasIndex("Key", "ContentPageId")
                        .IsUnique();

                    b.ToTable("ContentPageSections");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RentalCategories");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminComment")
                        .HasColumnType("longtext");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DealCoupon")
                        .HasColumnType("longtext");

                    b.Property<bool>("Done")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EndDate");

                    b.HasIndex("StartDate");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RentalId", "ProductId")
                        .IsUnique();

                    b.ToTable("RentalItems");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmountInStock")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NamePlural")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RentalProducts");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductPriceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId", "Quantity")
                        .IsUnique();

                    b.ToTable("RentalProductPrices");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageImageEntity", b =>
                {
                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageEntity", "ContentPage")
                        .WithMany("Images")
                        .HasForeignKey("ContentPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentPage");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageSectionEntity", b =>
                {
                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageEntity", "ContentPage")
                        .WithMany("Sections")
                        .HasForeignKey("ContentPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentPage");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalEntity", b =>
                {
                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalCategoryEntity", "Category")
                        .WithMany("Rentals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalItemEntity", b =>
                {
                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductEntity", "Product")
                        .WithMany("RentalItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalEntity", "Rental")
                        .WithMany("Items")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductPriceEntity", b =>
                {
                    b.HasOne("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductEntity", "Product")
                        .WithMany("Prices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.ContentPageEntity", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalCategoryEntity", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalEntity", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Aarhusvandsportscenter.Api.Infastructure.Database.Entities.RentalProductEntity", b =>
                {
                    b.Navigation("Prices");

                    b.Navigation("RentalItems");
                });
#pragma warning restore 612, 618
        }
    }
}
