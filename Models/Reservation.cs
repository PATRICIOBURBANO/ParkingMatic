namespace ParkingMatic.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ParkingSpotId { get; set; }
        public virtual ParkingSpot ParkingSpot { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsCurrent { get; set; }
    }
}
