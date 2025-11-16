using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace projekt.Components {
    public partial class RecipeEditPage: ComponentBase
    {
        [Parameter]
        public string Title { get; set; }
        protected EditRecipeModel? model = new();
        protected ObservableCollection<Ingredient> Ingredients {get;set;} = new();


        protected class EditRecipeModel {
            public string? name;
            public string? description;
            public List<string>? ingredients;
            public string? preparationMethod;
        }

        public class Ingredient
        {
            public string Name { get; set; } = string.Empty;
            public string Quantity { get; set; } = string.Empty;
        }

        protected override void OnInitialized(){
            AddIngredient();
        }

        protected void Submit() {
        }

        protected void AddIngredient()
        {
            Ingredients.Add(new Ingredient());
            Console.WriteLine($"Dodano. Teraz: {Ingredients.Count}");
        }

        protected void RemoveIngredient(Ingredient ingredient)
        {
            if (Ingredients.Count > 1) // Zawsze zostaw przynajmniej jedno pole
                Ingredients.Remove(ingredient);
        }
    }
}
