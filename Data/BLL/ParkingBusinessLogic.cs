using ParkingMatic.Data.DAL;
using ParkingMatic.Models;

namespace ParkingMatic.Data.BLL
{
    public class ParkingBusinessLogic
    {

        IRepository<ParkingSpot> repo;
        public ParkingBusinessLogic (IRepository<ParkingSpot> db)
        {
            repo = db;
        }

        public void CreateParkingSpace(ParkingSpot spot)
        {
            if (spot.Id < 1)
            {
                throw new Exception("Must to be greater than 0");
            }
            else
            {
                repo.Create(spot);
            }
        }
    }
}
