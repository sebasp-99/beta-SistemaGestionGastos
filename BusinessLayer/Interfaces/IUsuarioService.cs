public interface IUsuarioService 
{ 
    Task<IEnumerable<Usuarios>> ObtenerTodosAsync(); 
    Task<Usuarios> ObtenerPorIdAsync(int Id); 
    Task<IEnumerable<Usuarios>> ObtenerPorUsuarioAsync(int usuarioId); 
    Task AgregarAsync(Usuarios usuario); 
    Task ActualizarAsync(Usuarios usuario); 
    Task EliminarAsync(int id); 
} 