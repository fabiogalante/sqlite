using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtigoSQLite.Model;
using Microsoft.EntityFrameworkCore;

namespace ArtigoSQLite.Data
{
    public class EleicoesDbContext : DbContext
    {
        public EleicoesDbContext(DbContextOptions<EleicoesDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Candidato> Candidato { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>().HasData(
                new Candidato {Id = 1, Nome = "ALVARO DIAS", Numero = 19, Partido = "PODE"},
                new Candidato {Id = 2, Nome = "CABO DACIOLO", Numero = 51, Partido = "PATRI" },
                new Candidato {Id = 3, Nome = "CIROS GOMES", Numero = 12, Partido = "PDT" },
                new Candidato {Id = 4, Nome = "EYMAEL", Numero = 27, Partido = "DC" },
                new Candidato {Id = 5, Nome = "FERNANDO HADDAD", Numero = 13, Partido = "PT" },
                new Candidato {Id = 6, Nome = "GERALDO ALCKIMIN", Numero = 45, Partido = "PSDB" },
                new Candidato {Id = 7, Nome = "GUILHERME BOULOS", Numero = 50, Partido = "PSOL" },
                new Candidato {Id = 8, Nome = "HENRIQUE MEIRELLES", Numero = 15, Partido = "MDB" },
                new Candidato { Id = 9, Nome = "JAIR BOLSONARO", Numero = 17, Partido = "PSL" },
                new Candidato {Id = 10, Nome = "JOÃO AMOÊDO", Numero = 30, Partido = "NOVO" },
                new Candidato {Id = 11, Nome = "JOÃO GOULART FILHO", Numero = 54, Partido = "PPL" },
                new Candidato {Id = 12, Nome = "MARINA SILVA", Numero = 18, Partido = "REDE" },
                new Candidato {Id = 13, Nome = "VERA", Numero = 17, Partido = "PSTU" });
        }
    }
}
