using System;
using Storage.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Storage.Migrations
{
    [DbContext(typeof(MeetupContext))]
    partial class MeetupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetupManager.Models.Meetup", b =>
                {
                    b.Property<int>("MeetupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetupPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetupTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Organizar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeetupId");

                    b.ToTable("Meetups");
                });
#pragma warning restore 612, 618
        }
    }
}
