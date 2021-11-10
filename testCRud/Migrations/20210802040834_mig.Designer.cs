﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testCrud.Data;

namespace testCrud.Migrations
{
    [DbContext(typeof(testCrudContext))]
    [Migration("20210802040834_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("testCrud.Models.Autores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<string>("Cpf");

                    b.Property<int?>("EditoraId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EditoraId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("testCrud.Models.Editora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPNJ");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Editora");
                });

            modelBuilder.Entity("testCrud.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Autor");

                    b.Property<int?>("AutoresId");

                    b.Property<string>("Data_de_Lancamento");

                    b.Property<string>("Edicao");

                    b.Property<string>("Editora");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("AutoresId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("testCrud.Models.Autores", b =>
                {
                    b.HasOne("testCrud.Models.Editora", "Editora")
                        .WithMany("Autores")
                        .HasForeignKey("EditoraId");
                });

            modelBuilder.Entity("testCrud.Models.Livro", b =>
                {
                    b.HasOne("testCrud.Models.Autores", "Autores")
                        .WithMany("Livros")
                        .HasForeignKey("AutoresId");
                });
#pragma warning restore 612, 618
        }
    }
}
