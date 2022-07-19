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
    public class ProductUpdateTabletsController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public ProductUpdateTabletsController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: ProductUpdateTablets
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductUpdateTablet.ToListAsync());
        }

        // GET: ProductUpdateTablets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateTablet = await _context.ProductUpdateTablet
                .FirstOrDefaultAsync(m => m.pUT_Id == id);
            if (productUpdateTablet == null)
            {
                return NotFound();
            }

            return View(productUpdateTablet);
        }

        // GET: ProductUpdateTablets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductUpdateTablets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductNameUp,YieldInline,YieldWifi,YieldRFCal,YieldNSFT,YieldRadCurr,YieldTOF,YieldANT,YieldMMI1,YieldMMI2,YieldAudio,YieldWriteNumber,YieldCFCUp,YieldMMI3,NtfInline,NtfWifi,NtfRFCal,NtfNSFT,NtfRadCurr,NtfTOF,NtfANT,NtfMMI1,NtfMMI2,NtfAudio,NtfWriteNumber,NtfCFCUp,NtfMMI3,MTimeInline,MTimeWifi,MTimeRFCal,MTimeNSFT,MTimeRadCurr,MTimeTOF,MTimeANT,MTimeMMI1,MTimeMMI2,MTimeAudio,MTimeWriteNumber,MTimeCFCUp,MTimeMMI3")] ProductUpdateTablet productUpdateTablet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productUpdateTablet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productUpdateTablet);
        }

        // GET: ProductUpdateTablets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateTablet = await _context.ProductUpdateTablet.FindAsync(id);
            if (productUpdateTablet == null)
            {
                return NotFound();
            }
            return View(productUpdateTablet);
        }

        // POST: ProductUpdateTablets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductNameUp,YieldInline,YieldWifi,YieldRFCal,YieldNSFT,YieldRadCurr,YieldTOF,YieldANT,YieldMMI1,YieldMMI2,YieldAudio,YieldWriteNumber,YieldCFCUp,YieldMMI3,NtfInline,NtfWifi,NtfRFCal,NtfNSFT,NtfRadCurr,NtfTOF,NtfANT,NtfMMI1,NtfMMI2,NtfAudio,NtfWriteNumber,NtfCFCUp,NtfMMI3,MTimeInline,MTimeWifi,MTimeRFCal,MTimeNSFT,MTimeRadCurr,MTimeTOF,MTimeANT,MTimeMMI1,MTimeMMI2,MTimeAudio,MTimeWriteNumber,MTimeCFCUp,MTimeMMI3")] ProductUpdateTablet productUpdateTablet)
        {
            if (id != productUpdateTablet.pUT_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productUpdateTablet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductUpdateTabletExists(productUpdateTablet.pUT_Id))
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
            return View(productUpdateTablet);
        }

        // GET: ProductUpdateTablets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUpdateTablet = await _context.ProductUpdateTablet
                .FirstOrDefaultAsync(m => m.pUT_Id == id);
            if (productUpdateTablet == null)
            {
                return NotFound();
            }

            return View(productUpdateTablet);
        }

        // POST: ProductUpdateTablets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productUpdateTablet = await _context.ProductUpdateTablet.FindAsync(id);
            _context.ProductUpdateTablet.Remove(productUpdateTablet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductUpdateTabletExists(int id)
        {
            return _context.ProductUpdateTablet.Any(e => e.pUT_Id == id);
        }
    }
}
