using System.ComponentModel.DataAnnotations.Schema;

namespace Webapipage.Models{
    public class Ingredient{
        public int ID { get; set; } 
        [ForeignKey("Food")]
        public int FoodId {get; set;}
        // public Food? Hello {get; set; }
        public string? Name { get; set; }
        public string? ingredient1 { get; set; }
        public string? amount1 { get; set; }
        public string? ingredient2 { get; set; }
        public string? amount2 { get; set; }
        public string? ingredient3 { get; set; }
        public string? amount3 { get; set; }
        public string? ingredient4 { get; set; }
        public string? amount4 { get; set; }
        public string? ingredient5 { get; set; }
        public string? amount5 { get; set; }
    }
    //     public class Ingredient{
    //     public int Id { get; set; }
    //     public int RecipeId { get; set; }
      
    //     public string? Name { get; set; }
    //     public string? Ingredient1 { get; set; }
    //     public string? Ingredient2 { get; set; }
    //     public string? Ingredient3 { get; set; }
    //     public string? Ingredient4 { get; set; }
    //     public string? Ingredient5 { get; set; }
    //     public string? Ingredient6 { get; set; }
    //     public string? Ingredient7 { get; set; }
    //     public string? Ingredient8 { get; set; }
    //     public string? Ingredient9 { get; set; }
    //     public string? Ingredient10 { get; set; }
        

    // }
}