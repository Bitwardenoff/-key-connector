﻿// <auto-generated />
using System;
using Bit.CryptoAgent.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bit.CryptoAgent.Migrations.Sqlite
{
    [DbContext(typeof(SqliteDatabaseContext))]
    [Migration("20210817205807_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Bit.CryptoAgent.Repositories.EntityFramework.ApplicationData", b =>
                {
                    b.Property<string>("SymmetricKey")
                        .HasColumnType("TEXT");

                    b.ToTable("ApplicationDatas");
                });

            modelBuilder.Entity("Bit.CryptoAgent.Repositories.EntityFramework.UserKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastAccessDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RevisionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
