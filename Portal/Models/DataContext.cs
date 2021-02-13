using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class DataContext:DbContext
    {
        public DbSet<ScheduleDB> Schedules { get; set; }
        public DbSet<PharmacyDB> Pharmacies { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduleDB>(entity =>
            {
                entity.ToTable(name: "ScheduleDB");
            });
            modelBuilder.Entity<PharmacyDB>(entity =>
            {
                //entity.HasNoKey().ToTable(name: "PharmacyDB");
                entity.ToTable(name: "PharmacyDB");
            });
        }*/
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ASWIN-PREDATOR\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True");
        }*/
    }
}
