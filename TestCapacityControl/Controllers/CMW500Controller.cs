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
    public class CMW500Controller : Controller
    {
        private readonly TestCapacityControlContext _context;

        public CMW500Controller(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: CMW500
        public async Task<IActionResult> Index()
        {
            var Updated = from s in _context.CMW500 //Returning Date by order
                            select s;

            Updated = Updated.OrderBy(s => s.Updated);

            return View(await Updated.AsNoTracking().ToListAsync());

            //return View(await _context.CMW500.ToListAsync());
        }

        // GET: CMW500/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMW500 = await _context.CMW500
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cMW500 == null)
            {
                return NotFound();
            }

            return View(cMW500);
        }

        // GET: CMW500/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CMW500/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Updated,Site,Group,Last_Station,Id_Motorola,Id_Flex,SerialNumber,Type,KM550_LTE_TDD,KM011_QC_CAL,KV113_MTK_CAL,KM800_CDMA,KB036_6GHz,KV120_Unisoc,WiFi_KM650_KM610,Comments")] CMW500 cMW500)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cMW500);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cMW500);
        }

        // GET: CMW500/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMW500 = await _context.CMW500.FindAsync(id);
            if (cMW500 == null)
            {
                return NotFound();
            }
            return View(cMW500);
        }

        // POST: CMW500/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Updated,Site,Group,Last_Station,Id_Motorola,Id_Flex,SerialNumber,Type,KM550_LTE_TDD,KM011_QC_CAL,KV113_MTK_CAL,KM800_CDMA,KB036_6GHz,KV120_Unisoc,WiFi_KM650_KM610,Comments")] CMW500 cMW500)
        {
            if (id != cMW500.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cMW500);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CMW500Exists(cMW500.Id))
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
            return View(cMW500);
        }

        // GET: CMW500/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMW500 = await _context.CMW500
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cMW500 == null)
            {
                return NotFound();
            }

            return View(cMW500);
        }

        // POST: CMW500/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cMW500 = await _context.CMW500.FindAsync(id);
            _context.CMW500.Remove(cMW500);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CMW500Exists(int id)
        {
            return _context.CMW500.Any(e => e.Id == id);
        }
    }
}
