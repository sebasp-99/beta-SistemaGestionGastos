using MicrosoftEntityframeworkCore;

public class SistemaGestionGastosContext : DbContext {

    private readonly string connString = "Data Source=DESKTOP-93F6DCK;Database=SistemaGestionGastosBD;Integrated Security=True;";

    public SistemaGestionGastosContext(DbContextOptions<SistemaGestionGastosContext> options, string connString){
        connString = connString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connString);
    }

}