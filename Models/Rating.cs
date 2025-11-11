using System.ComponentModel.DataAnnotations;

public class Rating
{
    public int Id { get; set; }

    // Ilość gwiazdek
    [Required(ErrorMessage = "Wprowadź liczbę gwiazdek!")]
    [Range(1, 5, ErrorMessage = "Liczba gwiazdek musi być między 1 a 5")]
    public int Stars { get; set; } = 1;

    // Użytkownik (Recenzent)
    [Required(ErrorMessage = "Wprowadź użytkownika!")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    // Przepis
    [Required(ErrorMessage = "Wprowadź przepis!")]
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; } = null!;
}
