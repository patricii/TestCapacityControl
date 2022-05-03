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
    public class ProductUpdateCelularsController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public ProductUpdateCelularsController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: ProductUpdateCelulars
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductUpdateCelular.ToListAsync());
        }

        // GET: ProductUpdateCelulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateCelular = await _context.ProductUpdateCelular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productUpdateCelular == null)
            {
                return NotFound();
            }

            return View(productUpdateCelular);
        }

        // GET: ProductUpdateCelulars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductUpdateCelulars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductNameUp,YieldInline,YieldBrdTest,YieldBoardTst,Yield5GFR,YieldDCAL,YieldDVAL,YieldCamCAL,YieldCamVAL,YieldJOT,YieldL2Vision,YieldL2AR,YieldM2Cam,YieldM2AR,YieldJotSlim,YieldARSlim,YieldCFC,YieldPatsJot,YieldPatsM2,YieldPatsSlim,NtfInline,NtfBrdTest,NtfBoardTst,Ntf5GFR,NtfDCAL,NtfDVAL,NtfCamCAL,NtfCamVAL,NtfJOT,NtfL2Vision,NtfL2AR,NtfM2Cam,NtfM2AR,NtfJotSlim,NtfARSlim,NtfCFC,NtfPatsJot,NtfPatsM2,NtfPatsSlim,MTimeInline,MTimeBrdTest,MTimeBoardTst,MTime5GFR,MTimeDCAL,MTimeDVAL,MTimeCamCAL,MTimeCamVAL,MTimeJOT,MTimeL2Vision,MTimeL2AR,MTimeM2Cam,MTimeM2AR,MTimeJotSlim,MTimeARSlim,MTimeCFC,MTimePatsJot,MTimePatsM2,MTimePatsSlim")] ProductUpdateCelular productUpdateCelular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productUpdateCelular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productUpdateCelular);
        }

        // GET: ProductUpdateCelulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateCelular = await _context.ProductUpdateCelular.FindAsync(id);
            if (productUpdateCelular == null)
            {
                return NotFound();
            }
            return View(productUpdateCelular);
        }

        // POST: ProductUpdateCelulars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductNameUp,YieldInline,YieldBrdTest,YieldBoardTst,Yield5GFR,YieldDCAL,YieldDVAL,YieldCamCAL,YieldCamVAL,YieldJOT,YieldL2Vision,YieldL2AR,YieldM2Cam,YieldM2AR,YieldJotSlim,YieldARSlim,YieldCFC,YieldPatsJot,YieldPatsM2,YieldPatsSlim,NtfInline,NtfBrdTest,NtfBoardTst,Ntf5GFR,NtfDCAL,NtfDVAL,NtfCamCAL,NtfCamVAL,NtfJOT,NtfL2Vision,NtfL2AR,NtfM2Cam,NtfM2AR,NtfJotSlim,NtfARSlim,NtfCFC,NtfPatsJot,NtfPatsM2,NtfPatsSlim,MTimeInline,MTimeBrdTest,MTimeBoardTst,MTime5GFR,MTimeDCAL,MTimeDVAL,MTimeCamCAL,MTimeCamVAL,MTimeJOT,MTimeL2Vision,MTimeL2AR,MTimeM2Cam,MTimeM2AR,MTimeJotSlim,MTimeARSlim,MTimeCFC,MTimePatsJot,MTimePatsM2,MTimePatsSlim")] ProductUpdateCelular productUpdateCelular)
        {
            if (id != productUpdateCelular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productUpdateCelular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductUpdateCelularExists(productUpdateCelular.Id))
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
            return View(productUpdateCelular);
        }

        // GET: ProductUpdateCelulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateCelular = await _context.ProductUpdateCelular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productUpdateCelular == null)
            {
                return NotFound();
            }

            return View(productUpdateCelular);
        }

        // POST: ProductUpdateCelulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productUpdateCelular = await _context.ProductUpdateCelular.FindAsync(id);
            _context.ProductUpdateCelular.Remove(productUpdateCelular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductUpdateCelularExists(int id)
        {
            return _context.ProductUpdateCelular.Any(e => e.Id == id);
        }
    }
}
