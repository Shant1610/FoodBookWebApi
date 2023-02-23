using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Webapipage.Models{
    public class IngredientContext : IdentityDbContext
    {   
        public IngredientContext(DbContextOptions<IngredientContext> options ) : base(options)
        {

        }
        
public DbSet<Ingredient>? Ingredients {get; set;}
    }
}