using System;
using Microsoft.EntityFrameworkCore;

namespace FornecedorApi.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; } = null!;
    }
}

