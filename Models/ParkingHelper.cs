using ParkingMatic.Data;

namespace ParkingMatic.Models
{
    public class ParkingHelper
    {

        private ParkingMaticContext parkingContext;
        public ParkingHelper(ParkingMaticContext context)
        {
            this.parkingContext = context;
        }

        public Pass CreatePass(string client, bool premium, int capacity)
        {
            Pass newPass = new Pass(client);
            newPass.Purchaser = client;
            newPass.Premium = premium;
            newPass.Capacity = capacity;

            parkingContext.Pass.Add(newPass);
            parkingContext.SaveChanges();

            return newPass;
        }

        public ParkingSpot CreateParkingSpot(int occupancy)
        {
            ParkingSpot newSpot = new ParkingSpot(occupancy);
            newSpot.Occupied = false;

            parkingContext.ParkingSpot.Add(newSpot);
            return newSpot;
        }


    }
}
