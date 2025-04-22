public class GenericRepository<T> where T {
    
    private readonly string context;
    
    public GenericRepository(SistemaGestionGastosContext context) {
        context = context;
    }

    //Crear 5 metodos
    
    // FindAll || GetAll
    public async Task<IEnumerable<T>> GetAll () {
        return context.Set<T>().ToListAsync();
    }
    // FindOneById || GetOneById
    // Create
    // Update
    // Delete
}