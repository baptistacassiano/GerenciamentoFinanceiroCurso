using Microsoft.EntityFrameworkCore;

namespace GerenciamentoFinanceiroCurso.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
