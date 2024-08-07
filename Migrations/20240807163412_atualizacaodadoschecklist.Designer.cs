﻿// <auto-generated />
using System;
using KhoraControl.Setup.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KhoraControl.Migrations
{
    [DbContext(typeof(KhoraContext))]
    [Migration("20240807163412_atualizacaodadoschecklist")]
    partial class atualizacaodadoschecklist
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KhoraControl.Model.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DadosCheckListID")
                        .HasColumnType("integer");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DadosCheckListID");

                    b.ToTable("checklist");
                });

            modelBuilder.Entity("KhoraControl.Model.DadosCheckList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ID_Concessionaria")
                        .HasColumnType("integer");

                    b.Property<int>("ID_Item")
                        .HasColumnType("integer");

                    b.Property<int?>("ID_NotaFiscal")
                        .HasColumnType("integer");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("integer");

                    b.Property<int?>("KmRodados")
                        .HasColumnType("integer");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("dadosCheckLists");
                });

            modelBuilder.Entity("KhoraControl.Model.DadosNFe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("CNPJDestinatario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CNPJRemetente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChaveDeAcesso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataRevisao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("integer");

                    b.Property<string>("NaturezaOperacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumNFe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocialDestinatario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocialRemetente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("ValorTotalNotaFiscal")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorTotalProdutos")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("dadosNFe");
                });

            modelBuilder.Entity("KhoraControl.Model.Entidade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Ddd")
                        .HasColumnType("text");

                    b.Property<string>("Gia")
                        .HasColumnType("text");

                    b.Property<string>("Ibge")
                        .HasColumnType("text");

                    b.Property<string>("Localidade")
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Siafi")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Uf")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("entidade");

                    b.HasDiscriminator<string>("Tipo").HasValue("Entidade");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("KhoraControl.Model.Produtos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("CodigoProduto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ID_NFe")
                        .HasColumnType("integer");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroNFe")
                        .HasColumnType("text");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<double?>("ValorTotal")
                        .HasColumnType("double precision");

                    b.Property<double?>("ValorUnitario")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("KhoraControl.Model.Veiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DataDaCompra")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DataProximaRevisao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DataUltimaRevisao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ID_Concessionaria")
                        .HasColumnType("integer");

                    b.Property<int?>("ID_Empresa")
                        .HasColumnType("integer");

                    b.Property<int?>("KmProximaRevisao")
                        .HasColumnType("integer");

                    b.Property<int?>("KmQuandoComprado")
                        .HasColumnType("integer");

                    b.Property<int?>("KmRodados")
                        .HasColumnType("integer");

                    b.Property<int?>("KmUltimaRevisao")
                        .HasColumnType("integer");

                    b.Property<string>("LocalSalvamentoDeDados")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Motorista")
                        .HasColumnType("text");

                    b.Property<string>("NotaFiscalDeCompra")
                        .HasColumnType("text");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("StatusVeiculo")
                        .HasColumnType("character(1)");

                    b.Property<string>("SugestaoConcessionaria")
                        .HasColumnType("text");

                    b.Property<string>("TipoVeiculo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("veiculos");
                });

            modelBuilder.Entity("KhoraControl.Model.Concessionaria", b =>
                {
                    b.HasBaseType("KhoraControl.Model.Entidade");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("IE")
                        .HasColumnType("text");

                    b.ToTable("entidade", t =>
                        {
                            t.Property("CNPJ")
                                .HasColumnName("Concessionaria_CNPJ");

                            t.Property("IE")
                                .HasColumnName("Concessionaria_IE");
                        });

                    b.HasDiscriminator().HasValue("Concessionaria");
                });

            modelBuilder.Entity("KhoraControl.Model.Empresa", b =>
                {
                    b.HasBaseType("KhoraControl.Model.Entidade");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Empresa");
                });

            modelBuilder.Entity("KhoraControl.Model.CheckList", b =>
                {
                    b.HasOne("KhoraControl.Model.DadosCheckList", null)
                        .WithMany("CheckLists")
                        .HasForeignKey("DadosCheckListID");
                });

            modelBuilder.Entity("KhoraControl.Model.DadosCheckList", b =>
                {
                    b.Navigation("CheckLists");
                });
#pragma warning restore 612, 618
        }
    }
}
