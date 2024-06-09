using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace foodbookAPILastProject.Models;

public partial class FoodbookContext : DbContext
{
    public FoodbookContext()
    {
    }

    public FoodbookContext(DbContextOptions<FoodbookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IndividualCooker> IndividualCookers { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=IBRAHIM-LAPTOP\\SQLEXPRESS01;Database=foodbook;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IndividualCooker>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("individual_cookers");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.CookerName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Cooker_Name");
            entity.Property(e => e.MenuId).HasColumnName("Menu_ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phone");
            entity.Property(e => e.ReviewId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Review_ID");

            entity.HasOne(d => d.Menu).WithMany(p => p.IndividualCookers)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_individual_cookers_Menu");

            entity.HasOne(d => d.Review).WithMany(p => p.IndividualCookers)
                .HasForeignKey(d => d.ReviewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_individual_cookers_Review");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu");

            entity.Property(e => e.MenuId).HasColumnName("Menu_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ItemName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Item_NAME");
            entity.Property(e => e.Photo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("price");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Order");

            entity.Property(e => e.Ammount)
                .HasColumnType("money")
                .HasColumnName("ammount");
            entity.Property(e => e.OrderDescription)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("order_description");
            entity.Property(e => e.OrderId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Order_ID");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Payment_Method");
            entity.Property(e => e.Seller).HasColumnName("seller");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("status");

            entity.HasOne(d => d.BuyerNavigation).WithMany()
                .HasForeignKey(d => d.Buyer)
                .HasConstraintName("FK_Order_user1");

            entity.HasOne(d => d.SellerNavigation).WithMany()
                .HasForeignKey(d => d.Seller)
                .HasConstraintName("FK_Order_user");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Restaurant");

            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Mobilenumber)
                .HasMaxLength(50)
                .HasColumnName("mobilenumber");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestaurantId)
                .ValueGeneratedOnAdd()
                .HasColumnName("restaurant_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.ToTable("Review");

            entity.Property(e => e.ReviewId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Review_ID");
            entity.Property(e => e.ByUserId).HasColumnName("by_USER_ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("comment");
            entity.Property(e => e.Rating)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ReviewDate).HasColumnName("Review_Date");
            entity.Property(e => e.ToUserId).HasColumnName("to_User_ID");

            entity.HasOne(d => d.ByUser).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Review_user");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Last_Name");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.UserNavigation).WithOne(p => p.User)
                .HasForeignKey<User>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_individual_cookers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
