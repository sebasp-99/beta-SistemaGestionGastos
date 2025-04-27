public class MonedaService : IMonedaService 
{ 
    private readonly MonedasRepository _monedasRepository; 
    public MonedaService(MonedasRepository repo) 
    { 
        _monedasRepository = repo; 
    } 
    public async Task<IEnumerable<Monedas>> ObtenerTodosAsync() => 
        await _monedasRepository.GetAllAsync(); 

    public async Task<Monedas> ObtenerPorIdAsync(int id) => 
        await _monedasRepository.GetByIdAsync(id);

    public async Task<IEnumerable<Monedas>> ObtenerPorUsuarioAsync(int usuarioId) => 
        await _monedasRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); 

    public async Task AgregarAsync(Monedas moneda) => 
        await _monedasRepository.AddAsync(moneda); 

    public async Task ActualizarAsync(Monedas moneda) => 
        _monedasRepository.Update(moneda); 

    public async Task EliminarAsync(int id) 
    { 
        var moneda = await _monedasRepository.GetByIdAsync(id); 
        if (moneda != null) 
            _monedasRepository.Delete(moneda); 
    } 
} 