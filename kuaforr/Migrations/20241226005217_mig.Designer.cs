﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kuaforr.Data;

#nullable disable

namespace kuaforr.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241226005217_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kuaforr.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("kuaforr.Models.Calisanlarimiz", b =>
                {
                    b.Property<int>("CalisanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanId"));

                    b.Property<string>("CalisanFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalisanIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalisanMaas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalisanSoyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetId")
                        .HasColumnType("int");

                    b.Property<int?>("RandevuId")
                        .HasColumnType("int");

                    b.HasKey("CalisanId");

                    b.HasIndex("RandevuId");

                    b.ToTable("Calisanlarimizs");
                });

            modelBuilder.Entity("kuaforr.Models.Hizmetlerimiz", b =>
                {
                    b.Property<int>("HizmetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HizmetId"));

                    b.Property<int?>("CalisanlarimizCalisanId")
                        .HasColumnType("int");

                    b.Property<string>("HizmetFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetUcret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RandevuId")
                        .HasColumnType("int");

                    b.HasKey("HizmetId");

                    b.HasIndex("CalisanlarimizCalisanId");

                    b.HasIndex("RandevuId");

                    b.ToTable("Hizmetlerimizs");
                });

            modelBuilder.Entity("kuaforr.Models.Iletisim", b =>
                {
                    b.Property<int>("IletisimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IletisimId"));

                    b.Property<string>("IletisimAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimTelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IletisimId");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("kuaforr.Models.Randevu", b =>
                {
                    b.Property<int>("RandevuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RandevuId"));

                    b.Property<int>("CalisanId")
                        .HasColumnType("int");

                    b.Property<int>("HizmetId")
                        .HasColumnType("int");

                    b.Property<string>("RandevuIsimSoyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RandevuSaati")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RandevuTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RandevuId");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("kuaforr.Models.Calisanlarimiz", b =>
                {
                    b.HasOne("kuaforr.Models.Randevu", "Randevu")
                        .WithMany("Calisanlarimizs")
                        .HasForeignKey("RandevuId");

                    b.Navigation("Randevu");
                });

            modelBuilder.Entity("kuaforr.Models.Hizmetlerimiz", b =>
                {
                    b.HasOne("kuaforr.Models.Calisanlarimiz", "Calisanlarimiz")
                        .WithMany("Hizmetlerimizs")
                        .HasForeignKey("CalisanlarimizCalisanId");

                    b.HasOne("kuaforr.Models.Randevu", "Randevu")
                        .WithMany("Hizmetlerimizs")
                        .HasForeignKey("RandevuId");

                    b.Navigation("Calisanlarimiz");

                    b.Navigation("Randevu");
                });

            modelBuilder.Entity("kuaforr.Models.Calisanlarimiz", b =>
                {
                    b.Navigation("Hizmetlerimizs");
                });

            modelBuilder.Entity("kuaforr.Models.Randevu", b =>
                {
                    b.Navigation("Calisanlarimizs");

                    b.Navigation("Hizmetlerimizs");
                });
#pragma warning restore 612, 618
        }
    }
}
