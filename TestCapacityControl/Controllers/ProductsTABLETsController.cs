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
    public class ProductsTABLETsController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public ProductsTABLETsController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: ProductsTABLETs
        public async Task<IActionResult> Index()
        {
            var ProductsNames = from s in _context.ProductsTABLET //Returning Name by OrderBy
                                select s;

            ProductsNames = ProductsNames.OrderBy(s => s.ProductName);

            return View(await ProductsNames.AsNoTracking().ToListAsync());
            //return View(await _context.ProductsTABLET.ToListAsync());
        }

        // GET: ProductsTABLETs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsTABLET = await _context.ProductsTABLET
                .FirstOrDefaultAsync(m => m.productTablet_Id == id);
            if (productsTABLET == null)
            {
                return NotFound();
            }

            return View(productsTABLET);
        }

        // GET: ProductsTABLETs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductsTABLETs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,Model,Status")] ProductsTABLET productsTABLET)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsTABLET);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productsTABLET);
        }

        // GET: ProductsTABLETs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsTABLET = await _context.ProductsTABLET.FindAsync(id);
            if (productsTABLET == null)
            {
                return NotFound();
            }
            return View(productsTABLET);
        }

        // POST: ProductsTABLETs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,Model,Status")] ProductsTABLET productsTABLET)
        {
            if (id != productsTABLET.productTablet_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsTABLET);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsTABLETExists(productsTABLET.productTablet_Id))
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
            return View(productsTABLET);
        }

        // GET: ProductsTABLETs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsTABLET = await _context.ProductsTABLET
                .FirstOrDefaultAsync(m => m.productTablet_Id == id);
            if (productsTABLET == null)
            {
                return NotFound();
            }

            return View(productsTABLET);
        }

        // POST: ProductsTABLETs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productsTABLET = await _context.ProductsTABLET.FindAsync(id);
            _context.ProductsTABLET.Remove(productsTABLET);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsTABLETExists(int id)
        {
            return _context.ProductsTABLET.Any(e => e.productTablet_Id == id);
        }
    }
}
