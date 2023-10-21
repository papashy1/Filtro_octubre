using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
{
    private readonly ApiContext _context;
    public ProveedorRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Proveedor> GetByIdAsync(int id){
        return await _context.Proveedores
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Proveedor>> GetAllAsync(){
        return await _context.Proveedores.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Proveedor> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Proveedores as IQueryable<Proveedor>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreProveedor.ToLower().Contains(search));
        }
        var totalRegistros = await query.CountAsync();
        var registros = await query
                                 .Skip((pageIndex - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        return (totalRegistros, registros);
    }
}