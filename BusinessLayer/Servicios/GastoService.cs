public class GastoService : IGastoService 
{ 
    private readonly GastosRepository _gastosRepository; 
    public GastoService(GastosRepository repo) 
    { 
        _gastosRepository = repo; 
    } 
    public async Task<IEnumerable<Gastos>> ObtenerTodosAsync() => 
        await _gastosRepository.GetAllAsync(); 

    public async Task<Gastos> ObtenerPorIdAsync(int id) => 
        await _gastosRepository.GetByIdAsync(id);

    public async Task<IEnumerable<Gastos>> ObtenerPorUsuarioAsync(int usuarioId) => 
        await _gastosRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); 

    public async Task AgregarAsync(Gastos gasto) => 
        await _gastosRepository.AddAsync(gasto); 

    public async Task ActualizarAsync(Gastos gasto) => 
        _gastosRepository.Update(gasto); 

    public async Task EliminarAsync(int id) 
    { 
        var gasto = await _gastosRepository.GetByIdAsync(id); 
        if (gasto != null) 
            _gastosRepository.Delete(gasto); 
    } 
} 