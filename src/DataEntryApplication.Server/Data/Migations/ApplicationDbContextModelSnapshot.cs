﻿// <auto-generated />
using DataEntryApplication.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataEntryApplication.Server.Data.Migations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview3.19554.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataEntryApplication.Server.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DataEntryApplication.Server.Data.Entities.CMD1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CMD1");
                });
#pragma warning restore 612, 618
        }
    }
}
