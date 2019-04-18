﻿// <auto-generated />
using System;
using JustGo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JustGo.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JustGo.Data.EventsKeyMapping", b =>
                {
                    b.Property<int>("KudagoId");

                    b.Property<int>("OurId");

                    b.HasKey("KudagoId");

                    b.HasIndex("OurId");

                    b.ToTable("EventsKeyMappings");
                });

            modelBuilder.Entity("JustGo.Data.PlacesKeyMapping", b =>
                {
                    b.Property<int>("KudagoId");

                    b.Property<int>("OurId");

                    b.HasKey("KudagoId");

                    b.HasIndex("OurId");

                    b.ToTable("PlacesKeyMappings");
                });

            modelBuilder.Entity("JustGo.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JustGo.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Images");

                    b.Property<int>("PlaceId");

                    b.Property<string>("ShortTitle");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("JustGo.Models.EventCategory", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("CategoryId");

                    b.HasKey("EventId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventCategories");
                });

            modelBuilder.Entity("JustGo.Models.EventDate", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<DateTime>("Start");

                    b.Property<DateTime?>("End");

                    b.HasKey("EventId", "Start");

                    b.ToTable("EventDates");
                });

            modelBuilder.Entity("JustGo.Models.EventTag", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("TagId");

                    b.HasKey("EventId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("EventTags");
                });

            modelBuilder.Entity("JustGo.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("JustGo.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("JustGo.Data.EventsKeyMapping", b =>
                {
                    b.HasOne("JustGo.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("OurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Data.PlacesKeyMapping", b =>
                {
                    b.HasOne("JustGo.Models.Place", "Place")
                        .WithMany()
                        .HasForeignKey("OurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Models.Event", b =>
                {
                    b.HasOne("JustGo.Models.Place", "Place")
                        .WithMany("Events")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Models.EventCategory", b =>
                {
                    b.HasOne("JustGo.Models.Category", "Category")
                        .WithMany("EventCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JustGo.Models.Event", "Event")
                        .WithMany("EventCategories")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Models.EventDate", b =>
                {
                    b.HasOne("JustGo.Models.Event", "Event")
                        .WithMany("Dates")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Models.EventTag", b =>
                {
                    b.HasOne("JustGo.Models.Event", "Event")
                        .WithMany("EventTags")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JustGo.Models.Tag", "Tag")
                        .WithMany("EventTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JustGo.Models.Place", b =>
                {
                    b.OwnsOne("JustGo.Models.Coordinates", "Coordinates", b1 =>
                        {
                            b1.Property<int?>("PlaceId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Latitude");

                            b1.Property<double>("Longitude");

                            b1.ToTable("Places");

                            b1.HasOne("JustGo.Models.Place")
                                .WithOne("Coordinates")
                                .HasForeignKey("JustGo.Models.Coordinates", "PlaceId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
