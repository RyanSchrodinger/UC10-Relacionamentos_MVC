
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00003.Models;

public class MedicosController : Controller
{
    private readonly Uc_10_Ryan_Relacionamentos_Descricao_00003Context _context;

    public MedicosController(Uc_10_Ryan_Relacionamentos_Descricao_00003Context context)
    {
        _context = context;
    }

    // GET: MEDICOS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Medico.ToListAsync());
    }

    // GET: MEDICOS/Details/5
    public async Task<IActionResult> Details(int? medicoid)
    {
        if (medicoid == null)
        {
            return NotFound();
        }

        var medico = await _context.Medico
            .FirstOrDefaultAsync(m => m.MedicoId == medicoid);
        if (medico == null)
        {
            return NotFound();
        }

        return View(medico);
    }

    // GET: MEDICOS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: MEDICOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("MedicoId,Nome,CRM,EspecialidadeId,Especialidade,Pacientes")] Medico medico)
    {
        if (ModelState.IsValid)
        {
            _context.Add(medico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(medico);
    }

    // GET: MEDICOS/Edit/5
    public async Task<IActionResult> Edit(int? medicoid)
    {
        if (medicoid == null)
        {
            return NotFound();
        }

        var medico = await _context.Medico.FindAsync(medicoid);
        if (medico == null)
        {
            return NotFound();
        }
        return View(medico);
    }

    // POST: MEDICOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? medicoid, [Bind("MedicoId,Nome,CRM,EspecialidadeId,Especialidade,Pacientes")] Medico medico)
    {
        if (medicoid != medico.MedicoId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(medico);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicoExists(medico.MedicoId))
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
        return View(medico);
    }

    // GET: MEDICOS/Delete/5
    public async Task<IActionResult> Delete(int? medicoid)
    {
        if (medicoid == null)
        {
            return NotFound();
        }

        var medico = await _context.Medico
            .FirstOrDefaultAsync(m => m.MedicoId == medicoid);
        if (medico == null)
        {
            return NotFound();
        }

        return View(medico);
    }

    // POST: MEDICOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? medicoid)
    {
        var medico = await _context.Medico.FindAsync(medicoid);
        if (medico != null)
        {
            _context.Medico.Remove(medico);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MedicoExists(int? medicoid)
    {
        return _context.Medico.Any(e => e.MedicoId == medicoid);
    }
}
