﻿// <auto-generated />
using System;
using CadastroPaciente.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CadastroPaciente.Infrastructure.Migrations
{
    [DbContext(typeof(AgendeiContext))]
    [Migration("20231017011247_base_fornecedor")]
    partial class base_fornecedor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CadastroPaciente.Domain.Entities.ProviderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Cpf_Or_Cnpj")
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp");

                    b.HasKey("Id");

                    b.ToTable("fornecedor", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
