namespace SistemaGestionGastos

public class CategoriasRepository : GenericRepository {
    
    private genericRepository;
    public CategoriasRepository(GenericRepository genericRepository) {
        
        genericRepository = genericRepository;

    }

    //Traer todos los productos
    public async Task<Categorias> GetAll() {
        
        return genericRepository.GetAll();
    }
}