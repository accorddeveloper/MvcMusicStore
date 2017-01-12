using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDbContext>
    {
        protected override void Seed(MusicStoreDbContext context)
        {
            var genre = context.Genres.Add(new Genre { Name = "Grunge" });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Nirvana" },
                Genre = genre,
                Price = 7.99m,
                Title = "Nevermind"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Pearl Jam" },
                Genre = genre,
                Price = 8.99m,
                Title = "Ten"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Alice in Chains" },
                Genre = genre,
                Price = 9.99m,
                Title = "Dirt"
            });

            base.Seed(context);
        }
    }
}
