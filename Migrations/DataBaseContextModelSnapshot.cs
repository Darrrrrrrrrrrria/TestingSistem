﻿// <auto-generated />
using BlazorApp3.Components.Models.ModelsDataBases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp3.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("BlazorApp3.Models.QuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CorrectAnswerIndex")
                        .HasColumnType("INTEGER");

                    b.PrimitiveCollection<string>("Options")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TestModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TestModelId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("BlazorApp3.Models.TestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("BlazorApp3.Models.QuestionModel", b =>
                {
                    b.HasOne("BlazorApp3.Models.TestModel", "Test")
                        .WithMany("QuestionModels")
                        .HasForeignKey("TestModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("BlazorApp3.Models.TestModel", b =>
                {
                    b.Navigation("QuestionModels");
                });
#pragma warning restore 612, 618
        }
    }
}
