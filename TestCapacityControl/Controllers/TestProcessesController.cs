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
    public class TestProcessesController : Controller
    {
        private readonly TestCapacityControlContext _context;

        public TestProcessesController(TestCapacityControlContext context)
        {
            _context = context;
        }

        // GET: TestProcesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestProcess.ToListAsync());
        }

        // GET: TestProcesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testProcess = await _context.TestProcess
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testProcess == null)
            {
                return NotFound();
            }

            return View(testProcess);
        }

        // GET: TestProcesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestProcesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Technology,L2,M2,JOT_Slim,JOT,WUHAN_L2,WUHAN_JOT_Slim,WUHAN_JOT")] TestProcess testProcess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testProcess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testProcess);
        }

        // GET: TestProcesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testProcess = await _context.TestProcess.FindAsync(id);
            if (testProcess == null)
            {
                return NotFound();
            }
            return View(testProcess);
        }

        // POST: TestProcesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Technology,L2,M2,JOT_Slim,JOT,WUHAN_L2,WUHAN_JOT_Slim,WUHAN_JOT")] TestProcess testProcess)
        {
            if (id != testProcess.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testProcess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestProcessExists(testProcess.Id))
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
            return View(testProcess);
        }

        // GET: TestProcesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testProcess = await _context.TestProcess
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testProcess == null)
            {
                return NotFound();
            }

            return View(testProcess);
        }

        // POST: TestProcesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testProcess = await _context.TestProcess.FindAsync(id);
            _context.TestProcess.Remove(testProcess);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestProcessExists(int id)
        {
            return _context.TestProcess.Any(e => e.Id == id);
        }
    }
}
