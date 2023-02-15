﻿// <auto-generated />
using System;
using Ecommerce.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    [Migration("20230120231545_Adicionando ValorTotal em Vendas e ValorTotalVendas em Vendedor")]
    partial class AdicionandoValorTotalemVendaseValorTotalVendasemVendedor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.Models.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendaId"), 1L, 1);

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("Itens")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusVenda")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("real");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("VendaId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Ecommerce.Models.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendedorId"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<float>("ValorTotalVendas")
                        .HasColumnType("real");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Ecommerce.Models.Venda", b =>
                {
                    b.HasOne("Ecommerce.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Ecommerce.Models.Vendedor", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
