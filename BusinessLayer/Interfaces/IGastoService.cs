public interface IGastoService 
{ 
    Task<IEnumerable<Gastos>> ObtenerTodosAsync(); 
    Task<Gastos> ObtenerPorIdAsync(int Id); 
    Task<IEnumerable<Gastos>> ObtenerPorUsuarioAsync(int usuarioId); 
    Task AgregarAsync(Gastos gasto); 
    Task ActualizarAsync(Gastos gasto); 
    Task EliminarAsync(int id); 
} 