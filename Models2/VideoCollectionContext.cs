// For the database to be created, the following command is used:
//    dotnet ef database update
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace asp.net_folder.Models2
{

    public class VideoCollectionContext:DbContext
    {
            public VideoCollectionContext(DbContextOptions<VideoCollectionContext> options)
                : base(options)
            {
            }

            public DbSet<VideoCollection> VideoCollections { get; set; } = null!;
        }
}