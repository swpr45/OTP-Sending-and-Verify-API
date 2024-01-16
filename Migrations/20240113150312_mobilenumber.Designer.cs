﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OTP_Generator.Model.data;

#nullable disable

namespace OTP_Generator.Migrations
{
    [DbContext(typeof(OtpDbContext))]
    [Migration("20240113150312_mobilenumber")]
    partial class mobilenumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OTP_Generator.Model.User", b =>
                {
                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MobileNo");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
