public class Gastos {
    public int Id {get ; set ; }
    public int UsuarioId {get ; set ;}
    public int CategoriaId {get ; set ;}
    public int ModenaId {get ; set ;}
    public double Monto {get ; set ;}
    public date Fecha {get ; set ;}
    public string Descripcion{get ; set ;}

    //Relaciones
    public Usuarios Usuarios { get; set; } // Relación con el usuario
    public Categorias Categorias { get; set; } // Relación con la categoría
    public Monedas Monedas { get; set; } // Relación con la moneda
}