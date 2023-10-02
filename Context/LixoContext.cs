using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTeste.Context
{
    public class LixoContext : DbContext    
    {
        public LixoContext(DbContextOptions<LixoContext> options) : base (options)
        {

        }

        public DbSet<Usuario> Usuarios {get; set;}
    }
}