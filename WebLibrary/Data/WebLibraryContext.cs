using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;

namespace WebLibrary.Data;

public partial class WebLibraryContext : DbContext
{
    public WebLibraryContext(DbContextOptions<WebLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Issued> Issueds { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }
    
    public virtual DbSet<ViewBookIssued> ViewBookIssueds { get; set; }

    public virtual DbSet<ViewBookReservation> ViewBookReservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.Idautor).HasName("PRIMARY");

            entity.ToTable("autor");

            entity.Property(e => e.Idautor)
                .ValueGeneratedNever()
                .HasColumnName("idautor");
            entity.Property(e => e.Biography)
                .HasColumnType("text")
                .HasColumnName("biography");
            entity.Property(e => e.Dithday).HasColumnName("dithday");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .HasColumnName("full_name");

           
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Idbook).HasName("PRIMARY");

            entity.ToTable("book");

            entity.Property(e => e.Idbook)
                .ValueGeneratedNever()
                .HasColumnName("idbook");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Language)
                .HasMaxLength(45)
                .HasColumnName("language");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Page).HasColumnName("page");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Idgenre).HasName("PRIMARY");

            entity.ToTable("genre");

            entity.Property(e => e.Idgenre)
                .ValueGeneratedNever()
                .HasColumnName("idgenre");
            entity.Property(e => e.NameGenre)
                .HasMaxLength(45)
                .HasColumnName("name_genre");

           
        });

        modelBuilder.Entity<Issued>(entity =>
        {
            entity.HasKey(e => e.Idissued).HasName("PRIMARY");

            entity.ToTable("issued");

            entity.HasIndex(e => e.BookIdbook, "fk_issued_book1_idx");

            entity.HasIndex(e => e.StatusIdstatus, "fk_issued_status1_idx");

            entity.HasIndex(e => e.UserIduser, "fk_issued_user1_idx");

            entity.Property(e => e.Idissued)
                .ValueGeneratedNever()
                .HasColumnName("idissued");
            entity.Property(e => e.BookIdbook).HasColumnName("book_idbook");
            entity.Property(e => e.DateEnd).HasColumnName("date_end");
            entity.Property(e => e.DateStart).HasColumnName("date_start");
            entity.Property(e => e.StatusIdstatus).HasColumnName("status_idstatus");
            entity.Property(e => e.UserIduser).HasColumnName("user_iduser");

      

         

         
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Idreservation).HasName("PRIMARY");

            entity.ToTable("reservation");

            entity.HasIndex(e => e.BookIdbook, "fk_reservation_book1_idx");

            entity.HasIndex(e => e.StatusIdstatus, "fk_reservation_status1_idx");

            entity.HasIndex(e => e.UserIduser, "fk_reservation_user1_idx");

            entity.Property(e => e.Idreservation)
                .ValueGeneratedNever()
                .HasColumnName("idreservation");
            entity.Property(e => e.BookIdbook).HasColumnName("book_idbook");
            entity.Property(e => e.DateEndReserv).HasColumnName("date_end_reserv");
            entity.Property(e => e.DateReserv).HasColumnName("date_reserv");
            entity.Property(e => e.StatusIdstatus).HasColumnName("status_idstatus");
            entity.Property(e => e.Use).HasColumnName("use");
            entity.Property(e => e.UserIduser).HasColumnName("user_iduser");



         

          
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Idrole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Idrole)
                .ValueGeneratedNever()
                .HasColumnName("idrole");
            entity.Property(e => e.NameRole)
                .HasMaxLength(45)
                .HasColumnName("name_role");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Idstatus).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.Idstatus)
                .ValueGeneratedNever()
                .HasColumnName("idstatus");
            entity.Property(e => e.NameStatus)
                .HasMaxLength(45)
                .HasColumnName("name_status");
        });
        modelBuilder.Entity<ViewBookIssued>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_book_issued");

        });
        modelBuilder.Entity<ViewBookReservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_book_reservation");

        });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.RoleIdrole, "fk_user_role_idx");

            entity.Property(e => e.Iduser)
                .ValueGeneratedNever()
                .HasColumnName("iduser");
            entity.Property(e => e.Bithday).HasColumnName("bithday");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .HasColumnName("full_name");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.RoleIdrole).HasColumnName("role_idrole");

           // entity.HasOne(d => d.RoleIdroleNavigation).WithMany(p => p.Users)
              //  .HasForeignKey(d => d.RoleIdrole)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
             //   .HasConstraintName("fk_user_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
