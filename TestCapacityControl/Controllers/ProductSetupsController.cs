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
    public class ProductSetupsController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public ProductSetupsController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: ProductSetups
        public async Task<IActionResult> Index()
        {
            var ProductsNames = from s in _context.ProductSetup //Returning Name by OrderBy
                                select s;

            ProductsNames = ProductsNames.OrderBy(s => s.Product);

            return View(await ProductsNames.AsNoTracking().ToListAsync());
            //return View(await _context.ProductSetup.ToListAsync());
        }

        // GET: ProductSetups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSetup = await _context.ProductSetup
                .FirstOrDefaultAsync(m => m.productSetup_Id == id);
            if (productSetup == null)
            {
                return NotFound();
            }

            return View(productSetup);
        }

        // GET: ProductSetups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductSetups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,TestSets,PowerSupply,License,PSAUX,TDD,Freq6Ghz")] ProductSetup productSetup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productSetup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productSetup);
        }

        // GET: ProductSetups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSetup = await _context.ProductSetup.FindAsync(id);
            if (productSetup == null)
            {
                return NotFound();
            }
            return View(productSetup);
        }

        // POST: ProductSetups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Product,TestSets,PowerSupply,License,PSAUX,TDD,Freq6Ghz")] ProductSetup productSetup)
        {
            if (id != productSetup.productSetup_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productSetup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSetupExists(productSetup.productSetup_Id))
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
            return View(productSetup);
        }

        // GET: ProductSetups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSetup = await _context.ProductSetup
                .FirstOrDefaultAsync(m => m.productSetup_Id == id);
            if (productSetup == null)
            {
                return NotFound();
            }

            return View(productSetup);
        }

        // POST: ProductSetups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productSetup = await _context.ProductSetup.FindAsync(id);
            _context.ProductSetup.Remove(productSetup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSetupExists(int id)
        {
            return _context.ProductSetup.Any(e => e.productSetup_Id == id);
        }
    }
}
