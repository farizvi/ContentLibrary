namespace ContentLibrary.Data.Migrations
{
    using ContentLibrary.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContentLibrary.Data.Context.ContentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContentLibrary.Data.Context.ContentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (context.Entities.Count() == 0)
            {
                List<Entity> entities = new List<Entity>
            {
                new Entity { Type = "Image", Content = "http://example.com/someimage.jpg", Created = DateTime.Now },
                new Entity { Type = "Video", Content = "http://example.com/somevideo.mpeg", Created = DateTime.Now },
                new Entity { Type = "Text", Content = "http://example.com/somefile.txt", Created = DateTime.Now },
                new Entity { Type = "Text", Content = "http://example.com/anotherfile.txt", Created = DateTime.Now },
                new Entity { Type = "Image", Content = "http://example.com/anotherimage.jpg", Created = DateTime.Now }
            };

                context.Entities.AddRange(entities);
                context.SaveChanges();
            }
            
        }
    }
}
