using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Samples.AspCoreEF.DAL.EF.EntityFrameworkContext;

namespace Samples.AspCoreEF.DAL.EF.Migrations
{
    [DbContext(typeof(TaskSystemDbContext))]
    partial class TaskSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("Samples.AspCoreEF.DAL.EF.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Samples.AspCoreEF.DAL.EF.Models.Task", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int?>("AssignedToId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<byte>("State");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Samples.AspCoreEF.DAL.EF.Models.Task", b =>
                {
                    b.HasOne("Samples.AspCoreEF.DAL.EF.Models.Person", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId");
                });
        }
    }
}
