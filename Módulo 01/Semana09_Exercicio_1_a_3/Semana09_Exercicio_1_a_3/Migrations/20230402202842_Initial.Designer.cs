﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Semana09_Exercicio_1_a_3.Models;

#nullable disable

namespace Semana09_Exercicio_1_a_3.Migrations
{
    [DbContext(typeof(BercarioContexto))]
    [Migration("20230402202842_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Bebe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Mae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Parto")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso_Nascimento")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Mae");

                    b.HasIndex("Id_Parto");

                    b.ToTable("Bebe", (string)null);
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mae", (string)null);
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DData_Parto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horario_Parto")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Medico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Medico");

                    b.ToTable("Parto", (string)null);
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Bebe", b =>
                {
                    b.HasOne("Semana09_Exercicio_1_a_3.Models.Mae", "Mae")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Mae")
                        .IsRequired()
                        .HasConstraintName("FK__Bebe_Mae");

                    b.HasOne("Semana09_Exercicio_1_a_3.Models.Parto", "Parto")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Parto")
                        .IsRequired()
                        .HasConstraintName("FK__Bebe_Parto");

                    b.Navigation("Mae");

                    b.Navigation("Parto");
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Parto", b =>
                {
                    b.HasOne("Semana09_Exercicio_1_a_3.Models.Medico", "Medico")
                        .WithMany("Partos")
                        .HasForeignKey("Id_Medico")
                        .IsRequired()
                        .HasConstraintName("FK__Parto_Medico");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("Semana09_Exercicio_1_a_3.Models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}
