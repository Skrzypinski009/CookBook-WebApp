using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
        Users = Set<User>();
        Recipes = Set<Recipe>();
        Ratings = Set<Rating>();
        Ingredients = Set<Ingredient>();
        RecipeIngredients = Set<RecipeIngredient>();
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes {get; set; }
    public DbSet<Rating> Ratings {get; set; }
    public DbSet<Ingredient> Ingredients {get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients {get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Przepis - Użytkownik
        modelBuilder.Entity<Recipe>()
            .HasOne(r => r.User)
            .WithMany(u => u.Recipes)
            .HasForeignKey("UserId");

        // Ocena - Przepis
        modelBuilder.Entity<Rating>()
            .HasOne(r => r.Recipe)
            .WithMany(r => r.Ratings)
            .HasForeignKey("RecipeId");

        // Ocena - Użytkownik
        modelBuilder.Entity<Rating>()
            .HasOne(r => r.User)
            .WithMany(u => u.Ratings)
            .HasForeignKey("UserId");

        // Definicja klucza złożonego dla Przepis - Składnik
        modelBuilder.Entity<RecipeIngredient>()
            .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

        // Przepis - Składnik
        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ri => ri.Recipe)
            .WithMany(r => r.RecipeIngredients)
            .HasForeignKey("RecipeId");

        // Składnik - Przepis
        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ri => ri.Ingredient)
            .WithMany(i => i.RecipeIngredients)
            .HasForeignKey("IngredientId");
    }

}
