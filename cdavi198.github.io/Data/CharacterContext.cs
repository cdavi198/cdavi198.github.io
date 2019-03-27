using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cdavi198.github.io.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cdavi198.github.io.Data
{
    public class CharacterContext : DbContext
    {
        private readonly string schema;

        public CharacterContext(string schema) : base("CharacterContextConnectionString")
        {
            this.schema = schema;
        }

        public DbSet<CharactersEntity> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(this.schema);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}