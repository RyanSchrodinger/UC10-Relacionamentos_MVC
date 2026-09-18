using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00501.Models;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Controllers
{
    public class AutomovelController : Controller
    {
        private readonly Uc_10_Ryan_Relacionamentos_Descricao_00501Context _context;

        public AutomovelController(Uc_10_Ryan_Relacionamentos_Descricao_00501Context context)
        {
            _context = context;
        }

        // GET: Automovel
        public async Task<IActionResult> Index()
        {
            var uc_10_Ryan_Relacionamentos_Descricao_00501Context = _context.Automovel.Include(a => a.Marca);
            return View(await uc_10_Ryan_Relacionamentos_Descricao_00501Context.ToListAsync());
        }

        public IActionResult Vitrine()
        {
            return View();
        }
        public IActionResult Cuidados()
        {
            return View();
        }

        // GET: Automovel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel
                .Include(a => a.Marca)
                .FirstOrDefaultAsync(m => m.AutomovelId == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // GET: Automovel/Create
        public IActionResult Create()
        {
            ViewData["MarcaId"] = new SelectList(_context.Marca, "MarcaId", "Nome");
            return View();
        }

        // POST: Automovel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutomovelId,Modelo,Cor,Ano,Placa,MarcaId")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(automovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaId"] = new SelectList(_context.Marca, "MarcaId", "Nome", automovel.MarcaId);
            return View(automovel);
        }

        // GET: Automovel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }
            ViewData["MarcaId"] = new SelectList(_context.Marca, "MarcaId", "Nome", automovel.MarcaId);
            return View(automovel);
        }

        // POST: Automovel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutomovelId,Modelo,Cor,Ano,Placa,MarcaId")] Automovel automovel)
        {
            if (id != automovel.AutomovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(automovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutomovelExists(automovel.AutomovelId))
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
            ViewData["MarcaId"] = new SelectList(_context.Marca, "MarcaId", "Nome", automovel.MarcaId);
            return View(automovel);
        }

        // GET: Automovel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel
                .Include(a => a.Marca)
                .FirstOrDefaultAsync(m => m.AutomovelId == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // POST: Automovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var automovel = await _context.Automovel.FindAsync(id);
            if (automovel != null)
            {
                _context.Automovel.Remove(automovel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutomovelExists(int id)
        {
            return _context.Automovel.Any(e => e.AutomovelId == id);
        }
    }
}
