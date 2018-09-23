using ContentLibrary.Domain.Entities;
using Newtonsoft.Json;
using System.Data.Entity;
using System.IO;

namespace ContentLibrary.Data.Context
{
    public class ContentContext : DbContext
    {        
        public ContentContext() : base(setConnectionString())
        {
            
        }

        private static string setConnectionString()
        {
            dynamic dbInfo = JsonConvert.DeserializeObject(File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\configuration.json"));            
            return dbInfo.database.connectionString.Value;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>().ToTable("Entity");
        }

        public DbSet<Entity> Entities { get; set; }
    }
}
