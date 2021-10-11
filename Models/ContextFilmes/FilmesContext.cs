using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace FilmesCadastro.Models.ContextFilmes
{
    public class FilmesContext : DbContext
    {
        
        public DbSet<Filme> filmes { get; set; }

        public FilmesContext(DbContextOptions<FilmesContext> options) : base(options) { }
        
          
    }
}
