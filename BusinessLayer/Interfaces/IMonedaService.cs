public interface IMonedaService 
{ 
    Task<IEnumerable<Monedas>> ObtenerTodosAsync(); 
    Task<Monedas> ObtenerPorIdAsync(int Id); 
    Task<IEnumerable<Monedas>> ObtenerPorUsuarioAsync(int usuarioId); 
    Task AgregarAsync(Monedas moneda); 
    Task ActualizarAsync(Monedas moneda); 
    Task EliminarAsync(int id); 
} 