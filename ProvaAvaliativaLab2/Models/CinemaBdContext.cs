using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaAvaliativaLab2.Models
{
    public class CinemaBdContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CinemaBdContext() : base("name=CinemaBdContext")
        {
        }

        public System.Data.Entity.DbSet<ProvaAvaliativaLab2.Models.Sala> Salas { get; set; }

        public System.Data.Entity.DbSet<ProvaAvaliativaLab2.Models.Sessao> Sessaos { get; set; }

        public System.Data.Entity.DbSet<ProvaAvaliativaLab2.Models.Filme> Filmes { get; set; }

        public System.Data.Entity.DbSet<ProvaAvaliativaLab2.Models.Ator> Ators { get; set; }

        public System.Data.Entity.DbSet<ProvaAvaliativaLab2.Models.Ingresso> Ingressoes { get; set; }
    }
}
