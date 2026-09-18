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
    public class VendaController : Controller
    {
        private readonly Uc_10_Ryan_Relacionamentos_Descricao_00501Context _context;

        public VendaController(Uc_10_Ryan_Relacionamentos_Descricao_00501Context context)
        {
            _context = context;
        }

        // GET: Venda
        public async Task<IActionResult> Index()
        {
            var uc_10_Ryan_Relacionamentos_Descricao_00501Context = _context.Venda.Include(v => v.Automovel).Include(v => v.Cliente).Include(v => v.Vendedor);
            return View(await uc_10_Ryan_Relacionamentos_Descricao_00501Context.ToListAsync());
        }
        public IActionResult ComoComprar()
        {
            return View();
        }

        public IActionResult EtapasDaVenda()
        {
            return View();
        }
        // GET: Venda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda
                .Include(v => v.Automovel)
                .Include(v => v.Cliente)
                .Include(v => v.Vendedor)
                .FirstOrDefaultAsync(m => m.VendaId == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Venda/Create
        public IActionResult Create()
        {
            ViewData["AutomovelId"] = new SelectList(_context.Automovel, "AutomovelId", "Ano");
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Cpf");
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "Cpf");
            return View();
        }

        // POST: Venda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendaId,ClienteId,VendedorId,AutomovelId,DataVenda,ValorVenda")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutomovelId"] = new SelectList(_context.Automovel, "AutomovelId", "Ano", venda.AutomovelId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Cpf", venda.ClienteId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "Cpf", venda.VendedorId);
            return View(venda);
        }

        // GET: Venda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            ViewData["AutomovelId"] = new SelectList(_context.Automovel, "AutomovelId", "Ano", venda.AutomovelId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Cpf", venda.ClienteId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "Cpf", venda.VendedorId);
            return View(venda);
        }

        // POST: Venda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendaId,ClienteId,VendedorId,AutomovelId,DataVenda,ValorVenda")] Venda venda)
        {
            if (id != venda.VendaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(venda.VendaId))
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
            ViewData["AutomovelId"] = new SelectList(_context.Automovel, "AutomovelId", "Ano", venda.AutomovelId);
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Cpf", venda.ClienteId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "Cpf", venda.VendedorId);
            return View(venda);
        }

        // GET: Venda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda
                .Include(v => v.Automovel)
                .Include(v => v.Cliente)
                .Include(v => v.Vendedor)
                .FirstOrDefaultAsync(m => m.VendaId == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venda = await _context.Venda.FindAsync(id);
            if (venda != null)
            {
                _context.Venda.Remove(venda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id)
        {
            return _context.Venda.Any(e => e.VendaId == id);
        }
    }
}
