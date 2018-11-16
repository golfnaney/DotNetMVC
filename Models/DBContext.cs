using Microsoft.EntityFrameworkCore;

namespace TutorialDotNet.Models{
  public class DBContext : DbContext
  {
      public  DBContext(DbContextOptions<DBContext> options):base(options){
        
      }
      public DbSet<Products> Products {get;set;} 
      public DbSet<Category> Category {get;set;} 
  }
 
  
}