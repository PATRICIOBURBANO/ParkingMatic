using ParkingMatic.Data.DAL;
using ParkingMatic.Models;

namespace ParkingMatic.Data.BLL
{
    public class PassBusinessLogic
    {
        IRepository<Pass> repo;

        public PassBusinessLogic(IRepository<Pass> repository)
        {
            repo = repository;
        }

        public void CreatePass(Pass pass)
        {
            if (pass.Purchaser.Length >= 3 && pass.Purchaser.Length <= 20)
            {
                repo.Create(pass);
            }
            else
            {
                throw new Exception("Characters must be greater than 3 and less than 20");
            }

          
        }
    }
}
