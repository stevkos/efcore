﻿// <auto-generated />
using System;
using BankIS.MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankIS_MVC.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20210923114936_dob nullable2")]
    partial class dobnullable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankIS.MVC.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BankIS.MVC.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<int?>("HomeAddressId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankIS.MVC.Models.Client", b =>
                {
                    b.HasOne("BankIS.MVC.Models.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
