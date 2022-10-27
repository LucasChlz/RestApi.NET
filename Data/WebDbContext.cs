using Microsoft.EntityFrameworkCore;

namespace webApi.Api.Data
{
    public class WebDebContext: DbContext
    {
        public WebDebContext(DbContextOptions<WebDebContext> options): base(options)
        {
            
        }

        public DbSet<Models.Domain.Region> Regions { get; set; }
        public DbSet<Models.Domain.Walk> Walks { get; set; }
        public DbSet<Models.Domain.WalkDifFiculty> WalkDifFiculty { get; set; }
    }
}