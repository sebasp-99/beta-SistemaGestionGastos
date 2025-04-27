public class GenericRepository<T> where T : class{

    protected readonly DbContext _context;
    protected readonly DbSet<T> _dbSet;
    
    private readonly string context;
    
    public GenericRepository(SistemaGestionGastosContext context) {
        context = context;
        _dbSet = _context.Set<T>();
    }

    // Obtener todos los registros
    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    // Obtener un registro por ID
    public virtual async Task<T> GetByIdAsync(int Id)
    {
        return await _dbSet.FindAsync(Id);
    }

    // Agregar un nuevo registro
    public virtual async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    // Actualizar un registro existente
    public virtual void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    // Eliminar un registro
    public virtual void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    // Verificar si existe un registro según una condición
    public virtual async Task<bool> ExistsAsync(Expression<Func<T,bool>> predicate)
    {
        return await _dbSet.AnyAsync(predicate);
    }
    
    // FindAll || GetAll
    public async Task<IEnumerable<T>> GetAll () {
        return context.Set<T>().ToListAsync();
    }

}