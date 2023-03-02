﻿// <auto-generated />
using DistSysACW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DistSysACW.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DistSysACW.Models.User", b =>
                {
                    b.Property<string>("ApiKey")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.Property<string>("property");

                    b.HasKey("ApiKey");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
