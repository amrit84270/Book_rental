﻿// <auto-generated />
using Book_rental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Book_rental.Migrations
{
    [DbContext(typeof(Book_rentaldDatabase))]
    [Migration("20210211235602_Book")]
    partial class Book
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Book_rental.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Book_rental.Models.Books_detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books_detail");
                });

            modelBuilder.Entity("Book_rental.Models.Publication_detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Books_Copies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Books_detailId")
                        .HasColumnType("int");

                    b.Property<int>("Publisher_detailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Books_detailId");

                    b.HasIndex("Publisher_detailId");

                    b.ToTable("Publication_detail");
                });

            modelBuilder.Entity("Book_rental.Models.Publisher_detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publisher_detail");
                });

            modelBuilder.Entity("Book_rental.Models.Books_detail", b =>
                {
                    b.HasOne("Book_rental.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Book_rental.Models.Publication_detail", b =>
                {
                    b.HasOne("Book_rental.Models.Books_detail", "Books_detail")
                        .WithMany()
                        .HasForeignKey("Books_detailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book_rental.Models.Publisher_detail", "Publisher_detail")
                        .WithMany()
                        .HasForeignKey("Publisher_detailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books_detail");

                    b.Navigation("Publisher_detail");
                });
#pragma warning restore 612, 618
        }
    }
}
