using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.EntityFrameworkCore.Extensions;

namespace mysqlefcore
{
    public class DoctorContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhost;database=Movie;user=root;password=Password@12345"
            ConfigurationRoot configuration = (ConfigurationRoot)new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("AppSetting.json")
                            .Build();


            string connectionString = configuration.GetConnectionString("DefaultConnection");


            optionsBuilder.UseMySQL(connectionString);
     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DoctorID);
                entity.Property(e => e.DoctorName).IsRequired();
                entity.Property(d => d.DoctorAge);
                entity.Property(p => p.DoctorEmail);
                entity.Property(e => e.DoctorSpecialization);
                entity.Property(e=> e.DoctorContactNumber);
                 entity.Property(e=> e.DoctorLocation);
            });
        }

        private class MySqlServerVersion
        {
            private Version version;

            public MySqlServerVersion(Version version)
            {
                this.version = version;
            }
        }
    }
}

