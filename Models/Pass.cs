namespace ParkingMatic.Models
{

    public class Pass
    {
        public int Id { get; set; }
        public string Purchaser { get; set; }
        public bool Premium { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public Pass(string purchaser)
        {
            Purchaser = purchaser;
            Vehicles = new HashSet<Vehicle>();
        }

    }
}
