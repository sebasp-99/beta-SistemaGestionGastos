public class Usuarios {
    public int Id {get ; set ; }
    public string Nombre {get ; set ;}
    public string Email {get ; set ;}
    public string PasswordHash {get ; set ;}
    public datetime FechaRegitro {get ; set ;}

    //Relaciones
    public ICollection<Gastos> Gastos { get; set; } // Un usuario puede tener muchos gastos
    public ICollection<Presupuestos> Presupuestos { get; set; } // Un usuario puede tener muchos presupuestos
}