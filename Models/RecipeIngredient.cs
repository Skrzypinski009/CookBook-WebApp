using System.ComponentModel.DataAnnotations;

public class RecipeIngredient
{
    // Przepisy
    [Required(ErrorMessage = "Wprowadź przepis!")]
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; } = null!;

    // Składniki
    [Required(ErrorMessage = "Wprowadź składnik!")]
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; } = null!;


    [Required(ErrorMessage = "Wprowadź ilość!")]
    public string Quantity {get; set; } = String.Empty;
}
