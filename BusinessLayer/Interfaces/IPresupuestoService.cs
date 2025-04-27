public interface IPresupuestoService 
{ 
    Task<IEnumerable<Presupuestos>> ObtenerTodosAsync(); 
    Task<Presupuestos> ObtenerPorIdAsync(int Id); 
    Task<IEnumerable<Presupuestos>> ObtenerPorUsuarioAsync(int usuarioId); 
    Task AgregarAsync(Presupuestos presupuesto); 
    Task ActualizarAsync(Presupuestos presupuesto); 
    Task EliminarAsync(int id); 
} 