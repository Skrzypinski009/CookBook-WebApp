using System.ComponentModel.DataAnnotations;

public class Recipe
{
    public int Id { get; set; }

    // Nazwa
    [Required(ErrorMessage = "Nazwa jest wymagana!")]
    public string Name { get; set; } = string.Empty;

    // Opis
    [Required(ErrorMessage = "Opis jest wymagany!")]
    public string Description { get; set; } = string.Empty;

    // Sposób przygotowania
    [Required(ErrorMessage = "Sposób przygotowania jest wymagany!")]
    public string Instructions { get; set; } = string.Empty;

    // Połączenie Przepis-Składniki
    public List<RecipeIngredient> RecipeIngredients { get; set; } = new();

    // Autor
    [Required(ErrorMessage = "Wprowadź użytkownika!")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    // Oceny
    public List<Rating> Ratings { get; set; } = new();
}
