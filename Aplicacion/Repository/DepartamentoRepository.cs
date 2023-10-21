using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly ApiContext _context;
    public DepartamentoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Departamento> GetByIdAsync(int id){
        return await _context.Departamentos
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Departamento>> GetAllAsync(){
        return await _context.Departamentos.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Departamento> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Departamentos as IQueryable<Departamento>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreDepartamento.ToLower().Contains(search));
        }
        var totalRegistros = await query.CountAsync();
        var registros = await query
                                 .Skip((pageIndex - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        return (totalRegistros, registros);
    }
}