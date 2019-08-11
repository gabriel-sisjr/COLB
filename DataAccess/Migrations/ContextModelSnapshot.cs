﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.OrdemDeLiberacao", b =>
                {
                    b.Property<long>("NrOrdemDeLiberacao")
                        .HasColumnName("NR_ORDEM_DE_LIBERACAO");

                    b.Property<long>("NR_REQUISICAO");

                    b.HasKey("NrOrdemDeLiberacao");

                    b.HasIndex("NR_REQUISICAO");

                    b.ToTable("TB_ORDEM_DE_LIBERACAO");
                });

            modelBuilder.Entity("DataAccess.Entities.Perfil", b =>
                {
                    b.Property<int>("CdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CD_PERFIL")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DsPerfil")
                        .IsRequired()
                        .HasColumnName("DS_PERFIL");

                    b.HasKey("CdPerfil");

                    b.ToTable("TB_PERFIL");

                    b.HasData(
                        new
                        {
                            CdPerfil = 1,
                            DsPerfil = "Administrador"
                        },
                        new
                        {
                            CdPerfil = 2,
                            DsPerfil = "Funcionário"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Projeto", b =>
                {
                    b.Property<int>("CdProjeto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CD_PROJETO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CD_SOLUCAO");

                    b.Property<string>("DsProjeto")
                        .IsRequired()
                        .HasColumnName("DS_PROJETO");

                    b.Property<string>("NmProjeto")
                        .IsRequired()
                        .HasColumnName("NM_PROJETO");

                    b.HasKey("CdProjeto");

                    b.HasIndex("CD_SOLUCAO");

                    b.ToTable("TB_PROJETO");

                    b.HasData(
                        new
                        {
                            CdProjeto = 1,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Benefícios (Voucher)",
                            NmProjeto = "Api.Beneficios"
                        },
                        new
                        {
                            CdProjeto = 2,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Cartão",
                            NmProjeto = "Api.Cartao"
                        },
                        new
                        {
                            CdProjeto = 3,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Cliente",
                            NmProjeto = "Api.Cliente"
                        },
                        new
                        {
                            CdProjeto = 4,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Funcionário",
                            NmProjeto = "Api.Funcionario"
                        },
                        new
                        {
                            CdProjeto = 5,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Gerenciamento",
                            NmProjeto = "Api.Gerenciamento"
                        },
                        new
                        {
                            CdProjeto = 6,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Lojista",
                            NmProjeto = "Api.Lojista"
                        },
                        new
                        {
                            CdProjeto = 7,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Movimento",
                            NmProjeto = "Api.Movimento"
                        },
                        new
                        {
                            CdProjeto = 8,
                            CD_SOLUCAO = 1,
                            DsProjeto = "Api Seguranca",
                            NmProjeto = "Api.Seguranca"
                        },
                        new
                        {
                            CdProjeto = 9,
                            CD_SOLUCAO = 2,
                            DsProjeto = "Módulo Cliente",
                            NmProjeto = "SSC.Cliente"
                        },
                        new
                        {
                            CdProjeto = 10,
                            CD_SOLUCAO = 2,
                            DsProjeto = "Módulo Lojista",
                            NmProjeto = "SSC.Lojista"
                        },
                        new
                        {
                            CdProjeto = 11,
                            CD_SOLUCAO = 2,
                            DsProjeto = "Módulo Gerenciamento",
                            NmProjeto = "SSC.Gerenciamento"
                        },
                        new
                        {
                            CdProjeto = 12,
                            CD_SOLUCAO = 3,
                            DsProjeto = "Portal Cliente",
                            NmProjeto = "PortalCliente"
                        },
                        new
                        {
                            CdProjeto = 13,
                            CD_SOLUCAO = 3,
                            DsProjeto = "Portal Lojista",
                            NmProjeto = "PortalLojista"
                        },
                        new
                        {
                            CdProjeto = 14,
                            CD_SOLUCAO = 3,
                            DsProjeto = "Api pública Assistente",
                            NmProjeto = "PortalAssistente"
                        },
                        new
                        {
                            CdProjeto = 15,
                            CD_SOLUCAO = 3,
                            DsProjeto = "Api pública Benefícios",
                            NmProjeto = "PortalBeneficios"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.ProjetoAfetado", b =>
                {
                    b.Property<int>("CD_PROJETO");

                    b.Property<long>("NR_ORDEM_DE_LIBERACAO");

                    b.HasKey("CD_PROJETO", "NR_ORDEM_DE_LIBERACAO");

                    b.HasIndex("NR_ORDEM_DE_LIBERACAO");

                    b.ToTable("TB_PROJETO_AFETADO");
                });

            modelBuilder.Entity("DataAccess.Entities.Requisicao", b =>
                {
                    b.Property<long>("NrRequisicao")
                        .HasColumnName("NR_REQUISICAO");

                    b.Property<string>("DsRequisicao")
                        .IsRequired()
                        .HasColumnName("DS_REQUISICAO");

                    b.Property<DateTime>("DtSolicitacao")
                        .HasColumnName("DT_SOLICITACAO");

                    b.Property<string>("NmSolicitante")
                        .IsRequired()
                        .HasColumnName("NM_SOLICITANTE");

                    b.HasKey("NrRequisicao");

                    b.ToTable("TB_REQUISICAO");
                });

            modelBuilder.Entity("DataAccess.Entities.Solucao", b =>
                {
                    b.Property<int>("CdSolucao")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CD_SOLUCAO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DsSolucao")
                        .IsRequired()
                        .HasColumnName("DS_SOLUCAO");

                    b.Property<string>("NmSolucao")
                        .IsRequired()
                        .HasColumnName("NM_SOLUCAO");

                    b.HasKey("CdSolucao");

                    b.ToTable("TB_SOLUCAO");

                    b.HasData(
                        new
                        {
                            CdSolucao = 1,
                            DsSolucao = "Api privada e batches",
                            NmSolucao = "ssc-serviços"
                        },
                        new
                        {
                            CdSolucao = 2,
                            DsSolucao = "Sistema interno da SEAC",
                            NmSolucao = "ssc-modulos"
                        },
                        new
                        {
                            CdSolucao = 3,
                            DsSolucao = "Websites e apis públicas",
                            NmSolucao = "ssc-canais"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Usuario", b =>
                {
                    b.Property<int>("CdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CD_USUARIO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CD_PERFIL");

                    b.Property<string>("DsEmail")
                        .IsRequired()
                        .HasColumnName("DS_EMAIL");

                    b.Property<byte[]>("DsSenha")
                        .IsRequired()
                        .HasColumnName("DS_SENHA");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnName("DT_CADASTRO");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnName("DT_NASCIMENTO");

                    b.Property<bool>("FlAtivo")
                        .HasColumnName("FL_ATIVO");

                    b.Property<string>("NmUsuario")
                        .IsRequired()
                        .HasColumnName("NM_USUARIO");

                    b.Property<long>("NrTelefone")
                        .HasColumnName("NR_TELEFONE");

                    b.HasKey("CdUsuario");

                    b.HasIndex("CD_PERFIL");

                    b.HasIndex("DsEmail")
                        .IsUnique();

                    b.HasIndex("NrTelefone")
                        .IsUnique();

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("DataAccess.Entities.OrdemDeLiberacao", b =>
                {
                    b.HasOne("DataAccess.Entities.Requisicao", "Requisicao")
                        .WithMany("OrdensDeLiberacao")
                        .HasForeignKey("NR_REQUISICAO")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccess.Entities.Projeto", b =>
                {
                    b.HasOne("DataAccess.Entities.Solucao", "Solucao")
                        .WithMany("Projetos")
                        .HasForeignKey("CD_SOLUCAO")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccess.Entities.ProjetoAfetado", b =>
                {
                    b.HasOne("DataAccess.Entities.Projeto", "Projeto")
                        .WithMany("ProjetosAfetados")
                        .HasForeignKey("CD_PROJETO")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccess.Entities.OrdemDeLiberacao", "OrdemDeLiberacao")
                        .WithMany("ProjetosAfetados")
                        .HasForeignKey("NR_ORDEM_DE_LIBERACAO")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccess.Entities.Usuario", b =>
                {
                    b.HasOne("DataAccess.Entities.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("CD_PERFIL")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
