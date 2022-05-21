namespace ParkingMatic.Models
{

    public class ParkingSpot
    {
        public int Id { get; set; }
        public bool Occupied { get; set; }
        public int Occupancy { get; set; }  
        public virtual ICollection<Reservation> Reservations { get; set; }
        public ParkingSpot(int occupancy)
        { 
        Occupancy = occupancy;  
        Reservations = new HashSet<Reservation>();
        }
    }
}

