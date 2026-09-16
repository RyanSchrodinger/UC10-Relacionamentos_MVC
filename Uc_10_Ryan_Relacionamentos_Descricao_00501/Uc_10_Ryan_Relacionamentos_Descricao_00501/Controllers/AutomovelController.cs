
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00501.Models;

public class AutomovelController : Controller
{
    private readonly Uc_10_Ryan_Relacionamentos_Descricao_00501Context _context;

    public AutomovelController(Uc_10_Ryan_Relacionamentos_Descricao_00501Context context)
    {
        _context = context;
    }

    // GET: AUTOMOVELS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Automovel.ToListAsync());
    }

    public IActionResult Vitrine()
    {
        return View();
    }
    public IActionResult Cuidados()
    {
        return View();
    }
    // GET: AUTOMOVELS/Details/5{

    public async Task<IActionResult> Details(int? automovelid)
    {
        if (automovelid == null)
        {
            return NotFound();
        }

        var automovel = await _context.Automovel
            .FirstOrDefaultAsync(m => m.AutomovelId == automovelid);
        if (automovel == null)
        {
            return NotFound();
        }

        return View(automovel);
    }

    // GET: AUTOMOVELS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: AUTOMOVELS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("AutomovelId,Modelo,Cor,Ano,Placa,MarcaId,Marca,Vendas")] Automovel automovel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(automovel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(automovel);
    }

    // GET: AUTOMOVELS/Edit/5
    public async Task<IActionResult> Edit(int? automovelid)
    {
        if (automovelid == null)
        {
            return NotFound();
        }

        var automovel = await _context.Automovel.FindAsync(automovelid);
        if (automovel == null)
        {
            return NotFound();
        }
        return View(automovel);
    }

    // POST: AUTOMOVELS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? automovelid, [Bind("AutomovelId,Modelo,Cor,Ano,Placa,MarcaId,Marca,Vendas")] Automovel automovel)
    {
        if (automovelid != automovel.AutomovelId)
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
        return View(automovel);
    }

    // GET: AUTOMOVELS/Delete/5
    public async Task<IActionResult> Delete(int? automovelid)
    {
        if (automovelid == null)
        {
            return NotFound();
        }

        var automovel = await _context.Automovel
            .FirstOrDefaultAsync(m => m.AutomovelId == automovelid);
        if (automovel == null)
        {
            return NotFound();
        }

        return View(automovel);
    }

    // POST: AUTOMOVELS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? automovelid)
    {
        var automovel = await _context.Automovel.FindAsync(automovelid);
        if (automovel != null)
        {
            _context.Automovel.Remove(automovel);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AutomovelExists(int? automovelid)
    {
        return _context.Automovel.Any(e => e.AutomovelId == automovelid);
    }
}
