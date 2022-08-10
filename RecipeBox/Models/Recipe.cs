using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }

    public int RecipeId { get; set; }
    public string Title { get; set; }
    public string Instructions { get; set; }
    public string Ingredients { get; set; }
    public string Rating { get; set; }
    public virtual ApplicationUser User { get; set; } //new line

    public virtual ICollection<CategoryRecipe> JoinEntities { get;}
  }
}