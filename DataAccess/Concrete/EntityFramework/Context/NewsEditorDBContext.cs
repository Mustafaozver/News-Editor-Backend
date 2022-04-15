using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Context
{
    public class NewsEditorDBContext : DbContext
    {        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=HABER;Database=NewsEditorDB;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=10.5.5.45;Database=NewsEditorDB;User ID=sa;Password=Deal2019db;");
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<InCommingNews>? InCommingNews { get; set; }
        public DbSet<News>? News { get; set; }
        public DbSet<NewsCompany>? NewsCompanies { get; set; }
        public DbSet<NewsCategories>? NewsCategories { get; set; }
        public DbSet<NewsSymbol>? NewsSymbols { get; set; }
        public DbSet<SharedNews>? SharedNews { get; set; }
        public DbSet<SharedNewsCompany>? SharedNewsCompanies { get; set; }
        public DbSet<NewsSource>? NewsSources { get; set; }
        public DbSet<Source>? Sources { get; set; }
        public DbSet<Symbol>? Symbols { get; set; }


        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }

    }
}
