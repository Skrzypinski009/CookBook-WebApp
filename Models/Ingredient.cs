using System.ComponentModel.DataAnnotations;

public class Ingredient
{
    public int Id { get; set; }

    // Nazwa
    [Required(ErrorMessage = "Nazwa jest wymagana!")]
    public string Name { get; set; } = string.Empty;

    // Połączenie Składnik-Przepisy
    public List<RecipeIngredient> RecipeIngredients { get; set; } = new();
}
