using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeBonSamaritain.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Status> Statues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wish> Wishes { get; set; }
        public DbSet<AdType> AdTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.; Initial Catalog = DbLeBonSamaritain; Persist Security Info = True; User ID = DbLeBonSamariatin; Password = hugoDD");
        }
    }
}
