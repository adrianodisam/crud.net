using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testCrud.Models;

namespace testCrud.Data
{
    public class testCrudContext : DbContext
    {
        public testCrudContext (DbContextOptions<testCrudContext> options)
            : base(options)
        {
        }

        public DbSet<testCrud.Models.Livro> Livro { get; set; }
        public DbSet<testCrud.Models.Autores> Autores { get; set; }
        public DbSet<testCrud.Models.Editora> Editora{ get; set; }
       
    }
}
