public class PresupuestoService : IPresupuestoService 
{ 
    private readonly PresupuestosRepository _presupuestosRepository; 
    public PresupuestoService(PresupuestosRepository repo) 
    { 
        _presupuestosRepository = repo; 
    } 
    public async Task<IEnumerable<Presupuestos>> ObtenerTodosAsync() => 
        await _presupuestosRepository.GetAllAsync(); 

    public async Task<Presupuestos> ObtenerPorIdAsync(int id) => 
        await _presupuestosRepository.GetByIdAsync(id);

    public async Task<IEnumerable<Presupuestos>> ObtenerPorUsuarioAsync(int usuarioId) => 
        await _presupuestosRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); 

    public async Task AgregarAsync(Presupuestos presupuesto) => 
        await _presupuestosRepository.AddAsync(presupuesto); 

    public async Task ActualizarAsync(Presupuestos presupuesto) => 
        _presupuestosRepository.Update(presupuesto); 

    public async Task EliminarAsync(int id) 
    { 
        var presupuesto = await _presupuestosRepository.GetByIdAsync(id); 
        if (presupuesto != null) 
            _presupuestosRepository.Delete(presupuesto); 
    } 
} 