// <auto-generated />
using System;
using Estudio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Estudio.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Estudio.Models.Comentarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("comentario")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("t_comentarios");
                });

            modelBuilder.Entity("Estudio.Models.Construccion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcionConstruccion")
                        .HasColumnType("text");

                    b.Property<string>("imagenConstruccion")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("t_construccion");
                });

            modelBuilder.Entity("Estudio.Models.Consultoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcionConsultoria")
                        .HasColumnType("text");

                    b.Property<string>("imagenConsultoria")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("t_consultoria");
                });

            modelBuilder.Entity("Estudio.Models.DiseñoArquitectonico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcionDA")
                        .HasColumnType("text");

                    b.Property<string>("imagenDA")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("t_diseñoArquitectonico");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoCons", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("Consultoriaid")
                        .HasColumnType("integer");

                    b.Property<string>("procesoConsultoria")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Consultoriaid");

                    b.ToTable("t_procesoCons");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoConstruccion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("Construccionid")
                        .HasColumnType("integer");

                    b.Property<string>("procesoConstruccion")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Construccionid");

                    b.ToTable("t_procesoConstruccion");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoDA", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("DiseñoArquitectonicoid")
                        .HasColumnType("integer");

                    b.Property<string>("procesoDA")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("DiseñoArquitectonicoid");

                    b.ToTable("t_procesoDA");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoSa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("Saneamientoid")
                        .HasColumnType("integer");

                    b.Property<string>("procesoSa")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Saneamientoid");

                    b.ToTable("t_procesoSa");
                });

            modelBuilder.Entity("Estudio.Models.Proyectos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("imagen")
                        .HasColumnType("text");

                    b.Property<string>("lugar")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("precio")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("t_proyectos");
                });

            modelBuilder.Entity("Estudio.Models.Saneamiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descripcionSa")
                        .HasColumnType("text");

                    b.Property<string>("imagenSa")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("t_saneamiento");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoCons", b =>
                {
                    b.HasOne("Estudio.Models.Consultoria", "Consultoria")
                        .WithMany("procesoConsultoria")
                        .HasForeignKey("Consultoriaid");

                    b.Navigation("Consultoria");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoConstruccion", b =>
                {
                    b.HasOne("Estudio.Models.Construccion", "Construccion")
                        .WithMany("procesoConstruccion")
                        .HasForeignKey("Construccionid");

                    b.Navigation("Construccion");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoDA", b =>
                {
                    b.HasOne("Estudio.Models.DiseñoArquitectonico", "DiseñoArquitectonico")
                        .WithMany("procesoDA")
                        .HasForeignKey("DiseñoArquitectonicoid");

                    b.Navigation("DiseñoArquitectonico");
                });

            modelBuilder.Entity("Estudio.Models.ProcesoSa", b =>
                {
                    b.HasOne("Estudio.Models.Saneamiento", "Saneamiento")
                        .WithMany("procesoSa")
                        .HasForeignKey("Saneamientoid");

                    b.Navigation("Saneamiento");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Estudio.Models.Construccion", b =>
                {
                    b.Navigation("procesoConstruccion");
                });

            modelBuilder.Entity("Estudio.Models.Consultoria", b =>
                {
                    b.Navigation("procesoConsultoria");
                });

            modelBuilder.Entity("Estudio.Models.DiseñoArquitectonico", b =>
                {
                    b.Navigation("procesoDA");
                });

            modelBuilder.Entity("Estudio.Models.Saneamiento", b =>
                {
                    b.Navigation("procesoSa");
                });
#pragma warning restore 612, 618
        }
    }
}
