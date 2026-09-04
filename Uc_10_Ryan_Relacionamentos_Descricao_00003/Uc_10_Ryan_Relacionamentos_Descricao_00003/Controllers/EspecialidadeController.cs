
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00003.Models;

public class EspecialidadeController : Controller
{
    private readonly Uc_10_Ryan_Relacionamentos_Descricao_00003Context _context;

    public EspecialidadeController(Uc_10_Ryan_Relacionamentos_Descricao_00003Context context)
    {
        _context = context;
    }

    // GET: ESPECIALIDADES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Especialidade.ToListAsync());
    }

    // GET: ESPECIALIDADES/Details/5
    public async Task<IActionResult> Details(int? especialidadeid)
    {
        if (especialidadeid == null)
        {
            return NotFound();
        }

        var especialidade = await _context.Especialidade
            .FirstOrDefaultAsync(m => m.EspecialidadeId == especialidadeid);
        if (especialidade == null)
        {
            return NotFound();
        }

        return View(especialidade);
    }

    // GET: ESPECIALIDADES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ESPECIALIDADES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("EspecialidadeId,Nome,Medicos")] Especialidade especialidade)
    {
        if (ModelState.IsValid)
        {
            _context.Add(especialidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(especialidade);
    }

    // GET: ESPECIALIDADES/Edit/5
    public async Task<IActionResult> Edit(int? especialidadeid)
    {
        if (especialidadeid == null)
        {
            return NotFound();
        }

        var especialidade = await _context.Especialidade.FindAsync(especialidadeid);
        if (especialidade == null)
        {
            return NotFound();
        }
        return View(especialidade);
    }

    // POST: ESPECIALIDADES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? especialidadeid, [Bind("EspecialidadeId,Nome,Medicos")] Especialidade especialidade)
    {
        if (especialidadeid != especialidade.EspecialidadeId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(especialidade);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidadeExists(especialidade.EspecialidadeId))
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
        return View(especialidade);
    }

    // GET: ESPECIALIDADES/Delete/5
    public async Task<IActionResult> Delete(int? especialidadeid)
    {
        if (especialidadeid == null)
        {
            return NotFound();
        }

        var especialidade = await _context.Especialidade
            .FirstOrDefaultAsync(m => m.EspecialidadeId == especialidadeid);
        if (especialidade == null)
        {
            return NotFound();
        }

        return View(especialidade);
    }

    // POST: ESPECIALIDADES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? especialidadeid)
    {
        var especialidade = await _context.Especialidade.FindAsync(especialidadeid);
        if (especialidade != null)
        {
            _context.Especialidade.Remove(especialidade);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EspecialidadeExists(int? especialidadeid)
    {
        return _context.Especialidade.Any(e => e.EspecialidadeId == especialidadeid);
    }
}
