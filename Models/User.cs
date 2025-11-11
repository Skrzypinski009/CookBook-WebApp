using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    // Nazwa
    [Required(ErrorMessage = "Nazwa jest wymagana!")]
    public string Name { get; set; } = string.Empty;

    // Hasło
    [Required(ErrorMessage = "Email jest wymagany!")]
    public string Password { get; set; } = string.Empty;

    // Email
    [Required(ErrorMessage = "Email jest wymagany!")]
    public string Email { get; set; } = string.Empty;

    // Przepisy
    public List<Recipe> Recipes { get; set; } = new();

    // Oceny
    public List<Rating> Ratings { get; set; } = new();
}
