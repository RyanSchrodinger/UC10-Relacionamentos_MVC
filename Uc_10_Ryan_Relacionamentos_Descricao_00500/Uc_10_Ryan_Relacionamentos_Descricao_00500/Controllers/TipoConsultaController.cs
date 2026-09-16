using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00500.Data;
using Uc_10_Ryan_Relacionamentos_Descricao_00500.Models;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Controllers
{
    public class TipoConsultaController : Controller
    {
        private readonly Uc_10_Ryan_Relacionamentos_Descricao_00500Context _context;

        public TipoConsultaController(Uc_10_Ryan_Relacionamentos_Descricao_00500Context context)
        {
            _context = context;
        }

        // GET: TipoConsulta
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoConsulta.ToListAsync());
        }

        // GET: TipoConsulta/NossosAtendimentos
        public IActionResult NossosAtendimentos()
        {
            return View();
        }

        // GET: TipoConsulta/ComoEscolher
        public IActionResult ComoEscolher()
        {
            return View();
        }

        // GET: TipoConsulta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoConsulta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Valor")] TipoConsulta tipoConsulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoConsulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }
            return View(tipoConsulta);
        }

        // POST: TipoConsulta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Valor")] TipoConsulta tipoConsulta)
        {
            if (id != tipoConsulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoConsulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoConsultaExists(tipoConsulta.Id))
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
            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // POST: TipoConsulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta != null)
            {
                _context.TipoConsulta.Remove(tipoConsulta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoConsultaExists(int id)
        {
            return _context.TipoConsulta.Any(e => e.Id == id);
        }
    }
}
