using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestCapacityControl.Models;

namespace TestCapacityControl.Controllers
{
    public class TestRatesCelularsController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public TestRatesCelularsController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: TestRatesCelulars
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestRatesCelular.ToListAsync());
        }

        // GET: TestRatesCelulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRatesCelular = await _context.TestRatesCelular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testRatesCelular == null)
            {
                return NotFound();
            }

            return View(testRatesCelular);
        }

        // GET: TestRatesCelulars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestRatesCelulars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,product,CFCUph,CFCNt,PatsJotUph,PatsM2Uph,JOTSlimUph,JOTSlimPsps,JotSlimSpr,JOTSlimTotalUph,JOTSlimNt,L2ArSlimUph,L2ArSlimFxt,L2ArSlimSpr,L2ArSlimTotalUph,L2ArSlimNt,PATSSlimUph,CAMVALSlimUph,CAMVALSlimFxt,CAMVALSlimSpr,CAMVALSlimTotalUph,CAMVALSlimNt,CAMCALSlimUph,CAMCALSlimFxt,CAMCALSlimSpr,CAMCALSlimTotalUph,CAMCALSlimNt,FODSlimUph,FODSlimFxt,FODSlimSpr,FODSlimTotalUph,FODSlimNt")] TestRatesCelular testRatesCelular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testRatesCelular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testRatesCelular);
        }

        // GET: TestRatesCelulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRatesCelular = await _context.TestRatesCelular.FindAsync(id);
            if (testRatesCelular == null)
            {
                return NotFound();
            }
            return View(testRatesCelular);
        }

        // POST: TestRatesCelulars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,product,CFCUph,CFCNt,PatsJotUph,PatsM2Uph,JOTSlimUph,JOTSlimPsps,JotSlimSpr,JOTSlimTotalUph,JOTSlimNt,L2ArSlimUph,L2ArSlimFxt,L2ArSlimSpr,L2ArSlimTotalUph,L2ArSlimNt,PATSSlimUph,CAMVALSlimUph,CAMVALSlimFxt,CAMVALSlimSpr,CAMVALSlimTotalUph,CAMVALSlimNt,CAMCALSlimUph,CAMCALSlimFxt,CAMCALSlimSpr,CAMCALSlimTotalUph,CAMCALSlimNt,FODSlimUph,FODSlimFxt,FODSlimSpr,FODSlimTotalUph,FODSlimNt")] TestRatesCelular testRatesCelular)
        {
            if (id != testRatesCelular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testRatesCelular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestRatesCelularExists(testRatesCelular.Id))
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
            return View(testRatesCelular);
        }

        // GET: TestRatesCelulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRatesCelular = await _context.TestRatesCelular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testRatesCelular == null)
            {
                return NotFound();
            }

            return View(testRatesCelular);
        }

        // POST: TestRatesCelulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testRatesCelular = await _context.TestRatesCelular.FindAsync(id);
            _context.TestRatesCelular.Remove(testRatesCelular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestRatesCelularExists(int id)
        {
            return _context.TestRatesCelular.Any(e => e.Id == id);
        }
    }
}
