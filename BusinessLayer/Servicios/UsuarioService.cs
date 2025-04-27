public class UsuarioService : IUsuarioService 
{ 
    private readonly UsuariosRepository _usuariosRepository; 
    public UsuarioService(UsuariosRepository repo) 
    { 
        _usuariosRepository = repo; 
    } 
    public async Task<IEnumerable<Usuarios>> ObtenerTodosAsync() => 
        await _usuariosRepository.GetAllAsync(); 

    public async Task<Usuarios> ObtenerPorIdAsync(int id) => 
        await _usuariosRepository.GetByIdAsync(id);

    public async Task<IEnumerable<Usuarios>> ObtenerPorUsuarioAsync(int usuarioId) => 
        await _usuariosRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); 

    public async Task AgregarAsync(Usuarios usuario) => 
        await _usuariosRepository.AddAsync(usuario); 

    public async Task ActualizarAsync(Usuarios usuario) => 
        _usuariosRepository.Update(usuario); 

    public async Task EliminarAsync(int id) 
    { 
        var usuario = await _usuariosRepository.GetByIdAsync(id); 
        if ( usuario!= null) 
            _usuariossRepository.Delete(usuario); 
    } 
} 