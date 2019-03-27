using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cdavi198.github.io.Models;

namespace cdavi198.github.io.Data
{
    public class CharacterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CharacterContext>
    {
        protected override void Seed(CharacterContext context)
        {
            var characters = new List<CharactersEntity>
           {
               new CharactersEntity{Name="Arya Stark", Description="Blah", Image="URL", Price=2.5},
               new CharactersEntity{Name="Sansa Stark", Description="Blah", Image="URL", Price=1.5},
               new CharactersEntity{Name="John Snow", Description="Blah", Image="URL", Price=5},
               new CharactersEntity{Name="Danarys Targaryen", Description="Blah", Image="URL", Price=5},
               new CharactersEntity{Name="Night King", Description="Blah", Image="URL", Price=7}
           };

            characters.ForEach(c => context.Characters.Add(c));
            context.SaveChanges();
        }
    }
}