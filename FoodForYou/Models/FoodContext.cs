using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodForYou.Models;

public partial class FoodContext : DbContext
{
    public FoodContext()
    {
    }

    public FoodContext(DbContextOptions<FoodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Askthechef> Askthechefs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Chef> Chefs { get; set; }

    public virtual DbSet<ChefPic> ChefPics { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Instruction> Instructions { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipesLike> RecipesLikes { get; set; }

    public virtual DbSet<ServicesColinar> ServicesColinars { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FOOD;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AREAS__3214EC27EA65052F");

            entity.ToTable("AREAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(50)
                .HasColumnName("DESC");
        });

        modelBuilder.Entity<Askthechef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASKTHECH__3214EC27A160EEF9");

            entity.ToTable("ASKTHECHEF");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChefId).HasColumnName("CHEF_ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("PHONE");

            entity.HasOne(d => d.Chef).WithMany(p => p.Askthechefs)
                .HasForeignKey(d => d.ChefId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ASKTHECHE__CHEF___48CFD27E");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORY__3214EC274909F022");

            entity.ToTable("CATEGORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
        });

        modelBuilder.Entity<Chef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHEFS__3214EC27C599535D");

            entity.ToTable("CHEFS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AREA_ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName).HasColumnName("FIRST_NAME");
            entity.Property(e => e.Kosher)
                .HasMaxLength(100)
                .HasColumnName("KOSHER");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");
            entity.Property(e => e.UrlWebsite)
                .HasMaxLength(100)
                .HasColumnName("URL_WEBSITE");

            entity.HasOne(d => d.Area).WithMany(p => p.Chefs)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHEFS__AREA_ID__32E0915F");

            entity.HasOne(d => d.Service).WithMany(p => p.Chefs)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHEFS__SERVICE_I__33D4B598");
        });

        modelBuilder.Entity<ChefPic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHEF_PIC__3214EC278C839292");

            entity.ToTable("CHEF_PICS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChefId).HasColumnName("CHEF_ID");
            entity.Property(e => e.UrlPic)
                .HasMaxLength(100)
                .HasColumnName("URL_PIC");

            entity.HasOne(d => d.Chef).WithMany(p => p.ChefPics)
                .HasForeignKey(d => d.ChefId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHEF_PICS__CHEF___4CA06362");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COMMENTS__3214EC274CB705FF");

            entity.ToTable("COMMENTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.RecipeId).HasColumnName("RECIPE_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Comments)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__COMMENTS__RECIPE__5535A963");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__COMMENTS__USER_I__5629CD9C");
        });

        modelBuilder.Entity<Instruction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INSTRUCT__3214EC272309D9E5");

            entity.ToTable("INSTRUCTIONS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.RecipeId).HasColumnName("RECIPE_ID");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Instructions)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INSTRUCTI__RECIP__3F466844");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LEVEL__3214EC27821A1CFE");

            entity.ToTable("LEVEL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTS__3214EC27A4EADB6E");

            entity.ToTable("PRODUCTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.RecipeId).HasColumnName("RECIPE_ID");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Products)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__RECIPE__3C69FB99");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECIPES__3214EC2761B0134D");

            entity.ToTable("RECIPES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.ChefId).HasColumnName("CHEF_ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
            entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Time)
                .HasMaxLength(100)
                .HasColumnName("TIME");
            entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");
            entity.Property(e => e.UrlPic)
                .HasMaxLength(100)
                .HasColumnName("URL_PIC");

            entity.HasOne(d => d.Category).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES__CATEGOR__37A5467C");

            entity.HasOne(d => d.Chef).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ChefId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES__CHEF_ID__36B12243");

            entity.HasOne(d => d.Level).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES__LEVEL_I__38996AB5");

            entity.HasOne(d => d.Type).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES__TYPE_ID__398D8EEE");
        });

        modelBuilder.Entity<RecipesLike>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECIPES___3214EC2777C8EC5D");

            entity.ToTable("RECIPES_LIKE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RecipeId).HasColumnName("RECIPE_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipesLikes)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES_L__RECIP__45F365D3");

            entity.HasOne(d => d.User).WithMany(p => p.RecipesLikes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPES_L__USER___44FF419A");
        });

        modelBuilder.Entity<ServicesColinar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICES__3214EC27077DEADB");

            entity.ToTable("SERVICES_COLINAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TYPE__3214EC27EE32BBCF");

            entity.ToTable("TYPE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .HasColumnName("DESC");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USERS__3214EC278917A298");

            entity.ToTable("USERS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
