﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignFactory.Data;

#nullable disable

namespace SignFactory.Data.Migrations
{
    [DbContext(typeof(SignFactoryDbContext))]
    [Migration("20250112160957_SignFactoryDb")]
    partial class SignFactoryDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeOrder", b =>
                {
                    b.Property<string>("EmployeesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrdersId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeesId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("EmployeeOrder");
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InstallationAdress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SignTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SignTypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.SignType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("EmployeeOrder", b =>
                {
                    b.HasOne("SignFactory.Entities.Entity_Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SignFactory.Entities.Entity_Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.Order", b =>
                {
                    b.HasOne("SignFactory.Entities.Entity_Models.SignType", null)
                        .WithMany("Orders")
                        .HasForeignKey("SignTypeId");
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.SignType", b =>
                {
                    b.HasOne("SignFactory.Entities.Entity_Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("SignFactory.Entities.Entity_Models.SignType", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
