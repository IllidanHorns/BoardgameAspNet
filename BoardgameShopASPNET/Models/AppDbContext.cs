using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BoardgameShopASPNET.Models;

public partial class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountUser> AccountUsers { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AttributeType> AttributeTypes { get; set; }

    public virtual DbSet<AttributeValue> AttributeValues { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartPhoto> CartPhotos { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-J0029HVK\\SQLEXPRESS;Database=BoardgameShopASPNET;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountUser>(entity =>
        {
            entity.HasKey(e => e.IdAccount).HasName("PK__Account___213379EB762731C6");

            entity.ToTable("Account_user");

            entity.Property(e => e.IdAccount).HasColumnName("ID_Account");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Admins__69F567663528856B");

            entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttributeType>(entity =>
        {
            entity.HasKey(e => e.IdAttributeType).HasName("PK__Attribut__FE87E99414C78373");

            entity.Property(e => e.IdAttributeType).HasColumnName("ID_AttributeType");
            entity.Property(e => e.AttributeTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttributeValue>(entity =>
        {
            entity.HasKey(e => e.IdValueAttribure).HasName("PK__Attribut__8303888C2DA86DB6");

            entity.Property(e => e.IdValueAttribure).HasColumnName("ID_ValueAttribure");
            entity.Property(e => e.AttributeTypeId).HasColumnName("AttributeType_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.AttributeType).WithMany(p => p.AttributeValues)
                .HasForeignKey(d => d.AttributeTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Attribute__Attri__3C34F16F");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.IdCart).HasName("PK__Carts__72140ECFA4D762E0");

            entity.Property(e => e.IdCart).HasColumnName("ID_Cart");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.Product).WithMany(p => p.Carts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Carts__Product_I__245D67DE");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Carts__User_ID__236943A5");
        });

        modelBuilder.Entity<CartPhoto>(entity =>
        {
            entity.HasKey(e => e.IdCartPhoto).HasName("PK__CartPhot__D1E8BD53B765CE24");

            entity.ToTable("CartPhoto");

            entity.Property(e => e.IdCartPhoto).HasColumnName("ID_CartPhoto");
            entity.Property(e => e.PhotoId).HasColumnName("Photo_ID");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");

            entity.HasOne(d => d.Photo).WithMany(p => p.CartPhotos)
                .HasForeignKey(d => d.PhotoId)
                .HasConstraintName("FK__CartPhoto__Photo__45BE5BA9");

            entity.HasOne(d => d.Product).WithMany(p => p.CartPhotos)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CartPhoto__Produ__44CA3770");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.IdFavorite).HasName("PK__Favorite__FA228CCFEF1766AF");

            entity.HasIndex(e => new { e.UserId, e.ProductId }, "UQ_User_Product").IsUnique();

            entity.Property(e => e.IdFavorite).HasColumnName("ID_Favorite");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.Product).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Favorites__Produ__208CD6FA");

            entity.HasOne(d => d.User).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Favorites__User___1F98B2C1");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.IdPhoto).HasName("PK__Photo__DA88631125D6A82C");

            entity.ToTable("Photo");

            entity.Property(e => e.IdPhoto).HasColumnName("ID_Photo");
            entity.Property(e => e.LinkValue).HasColumnType("text");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Products__522DE4968F8FE3C1");

            entity.HasIndex(e => e.ProductName, "UQ__Products__DD5A978A62F75821").IsUnique();

            entity.Property(e => e.IdProduct).HasColumnName("ID_Product");
            entity.Property(e => e.CategoryId).HasColumnName("Category_ID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Products__Catego__1BC821DD");
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasKey(e => e.IdAttribute).HasName("PK__ProductA__9D1EB8026E7A27E8");

            entity.Property(e => e.IdAttribute).HasColumnName("ID_Attribute");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.ValueAttributeId).HasColumnName("ValueAttribute_ID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductAttributes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__ProductAt__Produ__40058253");

            entity.HasOne(d => d.ValueAttribute).WithMany(p => p.ProductAttributes)
                .HasForeignKey(d => d.ValueAttributeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__ProductAt__Value__40F9A68C");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("PK__ProductC__6DB3A68AD8FF7755");

            entity.Property(e => e.IdCategory).HasColumnName("ID_Category");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__Users__ED4DE442366EF2E8");

            entity.Property(e => e.IdUser).HasColumnName("ID_User");
            entity.Property(e => e.AccountId).HasColumnName("Account_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Account).WithMany(p => p.Users)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Users__Account_I__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
