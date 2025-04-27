public interface ICategoriaService 
{ 
    Task<IEnumerable<Categorias>> ObtenerTodosAsync(); 
    Task<Categorias> ObtenerPorIdAsync(int Id); 
    Task<IEnumerable<Categorias>> ObtenerPorUsuarioAsync(int usuarioId); 
    Task AgregarAsync(Categorias categoria); 
    Task ActualizarAsync(Categorias categoria); 
    Task EliminarAsync(int id); 
} 