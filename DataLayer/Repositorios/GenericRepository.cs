public class GenericRepository<T> where T {
    
    private readonly string context;
    
    public GenericRepository(SistemaGestionGastosContext context) {
        context = context;
    }
}