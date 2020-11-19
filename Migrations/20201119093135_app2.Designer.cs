﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PO7.Models;

namespace PO7.Migrations
{
    [DbContext(typeof(po7DbContext))]
    [Migration("20201119093135_app2")]
    partial class app2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PO7.Models.Gun", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("caliber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("weight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Gun");
                });

            modelBuilder.Entity("PO7.Models.ShootingResult", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("distance")
                        .HasColumnType("integer");

                    b.Property<int>("gunId")
                        .HasColumnType("integer");

                    b.Property<int>("points")
                        .HasColumnType("integer");

                    b.Property<int>("shots")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("gunId");

                    b.ToTable("ShootingResult");
                });

            modelBuilder.Entity("PO7.Models.ShootingResult", b =>
                {
                    b.HasOne("PO7.Models.Gun", "gun")
                        .WithMany("shootings")
                        .HasForeignKey("gunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gun");
                });

            modelBuilder.Entity("PO7.Models.Gun", b =>
                {
                    b.Navigation("shootings");
                });
#pragma warning restore 612, 618
        }
    }
}