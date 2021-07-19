using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
           

            modelBuilder.Entity<Country>()
            
                .Property(p =>p.UUID)
                .HasComputedColumnSql("'UID' + Right('00000000'+ CAST(ID AS VARCHAR(8)),8) PERSISTED");

            modelBuilder.Entity<Country>().HasData(
                
                new Country
                {
                    Id=3,
                    Name="Jamaica",
                    ShortName="JM"
                },
                new Country
                {   
                    Id=4,
                    Name = "Bahamas",
                    ShortName = "BS"  
                },
                 new Country
                 {
                     Id=5,
                     Name = "Brazil",
                     ShortName = "BR"
                 }

                );

            modelBuilder.Entity<Hotel>().HasData(

              new Hotel
              {
                  Id = 1,
                  Name = "Sandals Resort",
                  Address = "Negril",
                  CountryId = 2,
                  Rating = "4.5"
              },
              new Hotel
              {
                  Id = 2,
                  Name = "Radisson Resort",
                  Address = "George",
                  CountryId = 3,
                  Rating = "4"
              },
               new Hotel
               {
                   Id = 3,
                   Name = "A & W hotel",
                   Address = "Rio",
                   CountryId = 4,
                   Rating = "5"
               }

              );




        }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
