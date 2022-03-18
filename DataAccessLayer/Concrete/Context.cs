using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Dorm> Dorms { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Image> Images { get; set; }
    
    }
}
