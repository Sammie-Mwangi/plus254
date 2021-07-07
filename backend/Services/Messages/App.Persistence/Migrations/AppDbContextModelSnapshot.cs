﻿// <auto-generated />
using System;
using App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("App.Domain.Entities.Notifications.Notification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BCCRecipient")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Body")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("CCRecipient")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastEditedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("LastEditedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Recipient")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("RefId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sender")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RefId");

                    b.HasIndex("Sender");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("notification");
                });

            modelBuilder.Entity("App.Domain.Entities.Notifications.NotificationStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastEditedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("LastEditedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StatusDescription")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("StatusName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("StatusName");

                    b.ToTable("notification_status");
                });

            modelBuilder.Entity("App.Domain.Entities.Notifications.NotificationType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastEditedBy")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("LastEditedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TypeDescription")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TypeName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("TypeName");

                    b.ToTable("notification_type");
                });

            modelBuilder.Entity("App.Domain.Entities.Notifications.Notification", b =>
                {
                    b.HasOne("App.Domain.Entities.Notifications.NotificationStatus", "NotificationStatus")
                        .WithMany("Notifications")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Entities.Notifications.NotificationType", "NotificationType")
                        .WithMany("Notifications")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotificationStatus");

                    b.Navigation("NotificationType");
                });

            modelBuilder.Entity("App.Domain.Entities.Notifications.NotificationStatus", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("App.Domain.Entities.Notifications.NotificationType", b =>
                {
                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
