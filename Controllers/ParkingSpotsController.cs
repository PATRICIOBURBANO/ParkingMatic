using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingMatic.Data;
using ParkingMatic.Models;

namespace ParkingMatic.Controllers
{
    public class ParkingSpotsController : Controller
    {

        private readonly ParkingMaticContext _context;

        public ParkingSpotsController(ParkingMaticContext context)
        {
            _context = context;
        }
        // GET: ParkingSpotsController
        public ActionResult Index()
        {

            return View(_context.ParkingSpot.ToList());
        }

        // GET: ParkingSpotsController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = _context.ParkingSpot.FirstOrDefaultAsync(m => m.Id == id);
            if (parkingSpot == null)
            {
                return NotFound();
            }

            return View(parkingSpot);
        }

        // GET: ParkingSpotsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParkingSpotsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parked")] ParkingSpot parkingSpot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parkingSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parkingSpot);
        }

        // GET: ParkingSpotsController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = await _context.ParkingSpot.FindAsync(id);
            if (parkingSpot == null)
            {
                return NotFound();
            }
            return View(parkingSpot);
        }

        // POST: ParkingSpotsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parked")] ParkingSpot parkingSpot)
        {
            if (id != parkingSpot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkingSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkingSpotExists(parkingSpot.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parkingSpot);
        }
        // POST: ParkingSpotsController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = await _context.ParkingSpot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkingSpot == null)
            {
                return NotFound();
            }

            return View(parkingSpot);
        }

        // POST: ParkingSpaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parkingSpot = await _context.ParkingSpot.FindAsync(id);
            _context.ParkingSpot.Remove(parkingSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkingSpotExists(int id)
        {
            return _context.ParkingSpot.Any(e => e.Id == id);
        }
    }
}
