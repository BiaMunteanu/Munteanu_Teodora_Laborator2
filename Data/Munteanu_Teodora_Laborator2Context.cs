using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munteanu_Teodora_Laborator2.Models;

namespace Munteanu_Teodora_Laborator2.Data
{
    public class Munteanu_Teodora_Laborator2Context : DbContext
    {
        public Munteanu_Teodora_Laborator2Context (DbContextOptions<Munteanu_Teodora_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Munteanu_Teodora_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Munteanu_Teodora_Laborator2.Models.Publisher> Publisher { get; set; }

        public DbSet<Munteanu_Teodora_Laborator2.Models.Author> Author { get; set; }
    }
}
