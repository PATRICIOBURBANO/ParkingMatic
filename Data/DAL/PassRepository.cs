using ParkingMatic.Models;

namespace ParkingMatic.Data.DAL
{
    public class PassRepository
    {
        public ParkingMaticContext _db { get; set; }

        public PassRepository(ParkingMaticContext con)
        {
            _db = con;
        }

        public void Create(Pass pass)
        {
            _db.Add(pass);
        }

        public Pass Get(int id)
        {
            return _db.Pass.First(p => p.Id == id);
        }

        public Pass Get(Func<Pass, bool> firstFunction)
        {
            return _db.Pass.First(firstFunction);
        }

        public ICollection<Pass> GetAll()
        {
            return _db.Pass.ToList();
        }

        public ICollection<Pass> GetList(Func<Pass, bool> func)
        {
            return _db.Pass.Where(func).ToList();
        }

        public void Update(Pass pass)
        {
            _db.Pass.Update(pass);
        }

        public void Delete(Pass pass)
        {
            _db.Pass.Remove(pass);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
