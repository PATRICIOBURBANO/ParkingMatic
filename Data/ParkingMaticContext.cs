#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingMatic.Models;

namespace ParkingMatic.Data
{
    public class ParkingMaticContext : DbContext
    {
        public ParkingMaticContext (DbContextOptions<ParkingMaticContext> options)
            : base(options)
        {
        }

        public DbSet<ParkingMatic.Models.Vehicle> Vehicle { get; set; }
        public DbSet<ParkingMatic.Models.Reservation> Reservation { get; set; }
        public DbSet<ParkingMatic.Models.Pass> Pass { get; set; }
        public DbSet<ParkingMatic.Models.ParkingSpot> ParkingSpot { get; set; }
        

    }
}
