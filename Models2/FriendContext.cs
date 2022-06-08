// For the database to be created, the following command is used:
//    dotnet ef database update
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace asp.net_folder.Models2
{
   public class FriendContext : DbContext
   {
      public FriendContext(DbContextOptions<FriendContext> options)
          : base(options)
      {
      }

      public DbSet<Friend> Friends { get; set; } = null!;
   }
}