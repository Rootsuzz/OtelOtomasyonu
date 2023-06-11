﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelOtomasyonu.Data;

#nullable disable

namespace OtelOtomasyonu.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230522212451_ugursen")]
    partial class ugursen
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OtelOtomasyonu.Models.Odalar", b =>
                {
                    b.Property<int>("OdaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdaId"));

                    b.Property<bool>("KiralanmaDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("KisiSayisi")
                        .HasColumnType("int");

                    b.Property<int>("OdaKat")
                        .HasColumnType("int");

                    b.Property<int>("OdaNumarasi")
                        .HasColumnType("int");

                    b.HasKey("OdaId");

                    b.ToTable("Odalars");
                });
#pragma warning restore 612, 618
        }
    }
}
