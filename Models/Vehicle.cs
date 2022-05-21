namespace ParkingMatic.Models
{

    public class Vehicle
    {
        public int Id { get; set; }
        public int PassId { get; set; }
        public virtual Pass Pass { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public bool Parked { get; set; }

        public Vehicle ()
        {
            Reservations = new HashSet<Reservation> ();
        }
    }
}
