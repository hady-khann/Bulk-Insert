using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bulk_Insert.Models;
using Bulk_Insert.Services;

namespace Bulk_Insert.Controllers
{
    public class PersonsController : Controller
    {
        private readonly FakeDBContext _context;

        public PersonsController(FakeDBContext context)
        {
            _context = context;
        }

        // GET: Persons
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblPeople.ToListAsync());
        }

        // GET: Persons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPerson = await _context.TblPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPerson == null)
            {
                return NotFound();
            }

            return View(tblPerson);
        }

        // GET: Persons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Persons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fname,Lname,Age,Faname,Grade,Address")] TblPerson tblPerson)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(tblPerson);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}

            using (Parallel_Bulk PB = new Parallel_Bulk())
            {
                PB.Bulk_InTo_DB();
            };


            return View();
        }

        // GET: Persons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPerson = await _context.TblPeople.FindAsync(id);
            if (tblPerson == null)
            {
                return NotFound();
            }
            return View(tblPerson);
        }

        // POST: Persons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Fname,Lname,Age,Faname,Grade,Address")] TblPerson tblPerson)
        {
            if (id != tblPerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblPerson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPersonExists(tblPerson.Id))
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
            return View(tblPerson);
        }

        // GET: Persons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPerson = await _context.TblPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPerson == null)
            {
                return NotFound();
            }

            return View(tblPerson);
        }

        // POST: Persons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblPerson = await _context.TblPeople.FindAsync(id);
            _context.TblPeople.Remove(tblPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblPersonExists(string id)
        {
            return _context.TblPeople.Any(e => e.Id == id);
        }
    }
}
