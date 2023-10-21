using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
{
    private readonly ApiContext _context;
    public EmpresaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Empresa> GetByIdAsync(int id){
        return await _context.Empresas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Empresa>> GetAllAsync(){
        return await _context.Empresas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Empresa> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Empresas as IQueryable<Empresa>;
        if (!string.IsNullOrEmpty(search))
        {
            //query = query.Where(p => p.Nombre.ToLower().Contains(search));
        }
        var totalRegistros = await query.CountAsync();
        var registros = await query
                                 .Skip((pageIndex - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        return (totalRegistros, registros);
    }
}