public class CategoriaService : ICategoriaService 
{ 
    private readonly CategoriasRepository _categoriasRepository; 
    public CategoriaService(CategoriasRepository repo) 
    { 
        _categoriasRepository = repo; 
    } 
    public async Task<IEnumerable<Categorias>> ObtenerTodosAsync() => 
        await _categoriasRepository.GetAllAsync(); 

    public async Task<Categorias> ObtenerPorIdAsync(int id) => 
        await _categoriasRepository.GetByIdAsync(id);

    public async Task<IEnumerable<Categorias>> ObtenerPorUsuarioAsync(int usuarioId) => 
        await _categoriasRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); 

    public async Task AgregarAsync(Categorias categoria) => 
        await _categoriasRepository.AddAsync(categoria); 

    public async Task ActualizarAsync(Categorias categoria) => 
        _gastoRepository.Update(categoria); 

    public async Task EliminarAsync(int id) 
    { 
        var categoria = await _categoriasRepository.GetByIdAsync(id); 
        if (categoria != null) 
            _categoriasRepository.Delete(categoria); 
    } 
} 