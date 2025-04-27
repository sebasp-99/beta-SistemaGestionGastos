public class UsuariosRepository : GenericRepository<Usuarios> {
    private readonly SistemaGestionGastosContext _context;
    public UsuarioRepository(SistemaGestionGastosContext context) : base(context)
    {
        _context = context;
    }
 // Método específico: Obtener un usuario por su correo electrónico
    public async Task<Usuario> GetByEmailAsync(string email)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
    }
 // Método específico: Verificar si un correo electrónico ya está registrado
    public async Task<bool> EmailExistsAsync(string email)
    {
        return await _context.Usuarios.AnyAsync(u => u.Email == email);
    }
 // Método específico: Obtener todos los usuarios con sus gastos asociados
    public async Task<IEnumerable<Usuario>> GetAllWithGastosAsync()
    {
        return await _context.Usuarios
            .Include(u => u.Gastos) // Incluir los gastos relacionados
            .ToListAsync();
    }
    
       
}