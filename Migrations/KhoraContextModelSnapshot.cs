﻿// <auto-generated />
using System;
using KhoraControl.Setup.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KhoraControl.Migrations
{
    [DbContext(typeof(KhoraContext))]
    partial class KhoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("KhoraControl.Model.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DadosCheckListID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DadosCheckListID");

                    b.ToTable("checklist");
                });

            modelBuilder.Entity("KhoraControl.Model.DadosCheckList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("ID_Concessionaria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID_Item")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ID_NotaFiscal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KmRodados")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("dadosCheckLists");
                });

            modelBuilder.Entity("KhoraControl.Model.DadosNFe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJDestinatario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CNPJRemetente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChaveDeAcesso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRevisao")
                        .HasColumnType("TEXT");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NaturezaOperacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumNFe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RazaoSocialDestinatario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RazaoSocialRemetente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorTotalNotaFiscal")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorTotalProdutos")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("dadosNFe");
                });

            modelBuilder.Entity("KhoraControl.Model.Entidade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ddd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ibge")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .HasColumnType("TEXT");

                    b.Property<string>("Siafi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<string>("Uf")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("entidade");

                    b.HasDiscriminator<string>("Tipo").HasValue("Entidade");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("KhoraControl.Model.Produtos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ID_NFe")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID_Veiculo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumeroNFe")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("ValorTotal")
                        .HasColumnType("REAL");

                    b.Property<double?>("ValorUnitario")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("KhoraControl.Model.Veiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataDaCompra")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataProximaRevisao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataUltimaRevisao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ID_Concessionaria")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ID_Empresa")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KmProximaRevisao")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KmQuandoComprado")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KmRodados")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KmUltimaRevisao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocalSalvamentoDeDados")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Motorista")
                        .HasColumnType("TEXT");

                    b.Property<string>("NotaFiscalDeCompra")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SugestaoConcessionaria")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoVeiculo")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("veiculos");
                });

            modelBuilder.Entity("KhoraControl.Model.Concessionaria", b =>
                {
                    b.HasBaseType("KhoraControl.Model.Entidade");

                    b.Property<string>("CNPJ")
                        .HasColumnType("TEXT");

                    b.Property<string>("IE")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("TEXT");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
