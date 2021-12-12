﻿// <auto-generated />
using System;
using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBase.Migrations
{
    [DbContext(typeof(FactoryDbContext))]
    [Migration("20211211131655_Initial_Migration")]
    partial class Initial_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBase.Models.Address_costumers", b =>
                {
                    b.Property<int>("Address_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Apartment_Number")
                        .HasColumnType("int")
                        .HasColumnName("Apartment Number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<int>("costumers_ID")
                        .HasColumnType("int");

                    b.Property<int>("House_Number")
                        .HasColumnType("int")
                        .HasColumnName("House Number");

                    b.Property<string>("Street_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Street Name");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int")
                        .HasColumnName("Zipcode");

                    b.HasKey("Address_ID");

                    b.HasIndex("costumers_ID");

                    b.ToTable("Address_costumers");
                });

            modelBuilder.Entity("DataBase.Models.Address_Employees", b =>
                {
                    b.Property<int>("Address_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Apartment_Number")
                        .HasColumnType("int")
                        .HasColumnName("Apartment Number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<int>("Employee_ID")
                        .HasColumnType("int")
                        .HasColumnName("Employee Id");

                    b.Property<int>("House_Number")
                        .HasColumnType("int")
                        .HasColumnName("House Number");

                    b.Property<string>("Street_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Street Name");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int")
                        .HasColumnName("Zipcode");

                    b.HasKey("Address_ID")
                        .HasName("Address Id");

                    b.ToTable("address_Employees");
                });

            modelBuilder.Entity("DataBase.Models.Brands", b =>
                {
                    b.Property<int>("Brand_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Brand Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand_Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Brand Name");

                    b.Property<string>("Manufacturing_Country")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Manufacturing Country");

                    b.HasKey("Brand_Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DataBase.Models.Categories", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.HasKey("Category_ID")
                        .HasName("Category ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DataBase.Models.Connactions.EDIItems", b =>
                {
                    b.Property<int>("EDI_Id")
                        .HasColumnType("int");

                    b.Property<int>("Item_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("QuantityArrived")
                        .HasColumnType("int");

                    b.HasKey("EDI_Id", "Item_Id");

                    b.HasIndex("Item_Id");

                    b.ToTable("EIs");
                });

            modelBuilder.Entity("DataBase.Models.costumers", b =>
                {
                    b.Property<int>("costumers_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("costumer id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("First Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone number");

                    b.Property<string>("last_Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Last Name");

                    b.HasKey("costumers_ID");

                    b.ToTable("costumers");
                });

            modelBuilder.Entity("DataBase.Models.EDI", b =>
                {
                    b.Property<int>("EDI_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Approved_By")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_Items")
                        .HasColumnType("int");

                    b.Property<double>("Total_Weight")
                        .HasColumnType("float");

                    b.HasKey("EDI_Id");

                    b.HasIndex("Approved_By");

                    b.ToTable("EDIs");
                });

            modelBuilder.Entity("DataBase.Models.Employees", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("First Name");

                    b.Property<DateTime>("Hire_Date")
                        .HasColumnType("smalldatetime")
                        .HasColumnName("Hire Date");

                    b.Property<short>("Is_Manager")
                        .HasColumnType("smallint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone number");

                    b.Property<string>("last_Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Last Name");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DataBase.Models.Items", b =>
                {
                    b.Property<int>("Item_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Item Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Brand_Id")
                        .HasColumnType("int")
                        .HasColumnName("Brand Id");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int")
                        .HasColumnName("Category Id");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Item Name");

                    b.Property<int>("Minimum_Units_In_Inventory")
                        .HasColumnType("int")
                        .HasColumnName("Minimum Units In inventory");

                    b.Property<decimal>("Price")
                        .HasColumnType("smallmoney")
                        .HasColumnName("Unit Price");

                    b.Property<int>("Units_In_Inventory")
                        .HasColumnType("int")
                        .HasColumnName("Units In inventory");

                    b.Property<double>("Weight")
                        .HasColumnType("float")
                        .HasColumnName("Weight");

                    b.HasKey("Item_ID");

                    b.HasIndex("Brand_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DataBase.Models.Shifts", b =>
                {
                    b.Property<int>("Shift_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Employee_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Shift_End")
                        .HasColumnType("smalldatetime")
                        .HasColumnName("Shift end time");

                    b.Property<DateTime>("Shift_Start")
                        .HasColumnType("smalldatetime")
                        .HasColumnName("Shift start time");

                    b.Property<double>("Total_Time")
                        .HasColumnType("float")
                        .HasColumnName("Shift Time");

                    b.HasKey("Shift_ID");

                    b.HasIndex("Employee_ID");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("DataBase.Models.Address_costumers", b =>
                {
                    b.HasOne("DataBase.Models.costumers", "costumers")
                        .WithMany("Address")
                        .HasForeignKey("costumers_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("costumers");
                });

            modelBuilder.Entity("DataBase.Models.Connactions.EDIItems", b =>
                {
                    b.HasOne("DataBase.Models.EDI", "EDI")
                        .WithMany("Items")
                        .HasForeignKey("EDI_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Models.Items", "Items")
                        .WithMany("EDIs")
                        .HasForeignKey("Item_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EDI");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("DataBase.Models.EDI", b =>
                {
                    b.HasOne("DataBase.Models.Employees", "employee")
                        .WithMany("EDIs")
                        .HasForeignKey("Approved_By");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("DataBase.Models.Employees", b =>
                {
                    b.HasOne("DataBase.Models.Address_Employees", "Address")
                        .WithOne("employee")
                        .HasForeignKey("DataBase.Models.Employees", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DataBase.Models.Items", b =>
                {
                    b.HasOne("DataBase.Models.Brands", "Brand")
                        .WithMany("Items")
                        .HasForeignKey("Brand_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Models.Categories", "Category")
                        .WithMany("item")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DataBase.Models.Shifts", b =>
                {
                    b.HasOne("DataBase.Models.Employees", "Employee")
                        .WithMany("Shifts")
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DataBase.Models.Address_Employees", b =>
                {
                    b.Navigation("employee");
                });

            modelBuilder.Entity("DataBase.Models.Brands", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("DataBase.Models.Categories", b =>
                {
                    b.Navigation("item");
                });

            modelBuilder.Entity("DataBase.Models.costumers", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("DataBase.Models.EDI", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("DataBase.Models.Employees", b =>
                {
                    b.Navigation("EDIs");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("DataBase.Models.Items", b =>
                {
                    b.Navigation("EDIs");
                });
#pragma warning restore 612, 618
        }
    }
}
