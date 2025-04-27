# beta-SistemaGestionGastos

## App con modelo N-capas

* El comando 'dotnet new' crea un proyecto de .NET basado en una plantilla.

**Creamos la solución:**
dotnet new sln -n SistemaGestionGastos

### Crear capas (3):
**Datos y Logica de negocio:**
dotnet new classlib -n DataLayer
dotnet new classlib -n BusinessLayer

**Presentacion:**
dotnet new mvc -n PresentationLayer


### Instalar paquetes en DataLayer (debe estar ubicado en directorio de DataLayer)
**CLI de .NET Core**
Use el comando de la CLI de .NET Core en la línea de comandos del sistema operativo para instalar o actualizar el proveedor de SQL Server de EF Core:
* EF = Entity Framework

*dotnet add package Microsoft.EntityFrameworkCore.SqlServer*


**Obtención de las herramientas de la consola del Administrador de paquetes**
Para obtener las herramientas de la consola del Administrador de paquetes para EF Core

*dotnet add package Microsoft.EntityFrameworkCore.Tools*


**Inicialización básica de DbContext con "new"**
DbContext Las instancias se pueden construir con new en C#. La configuración se puede realizar invalidando el método OnConfiguring o pasando opciones al constructor. Por ejemplo:
Método en la clase:
* connString ---> cadena de conexion

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connString);
    }







**Comandos git:**
- git init
- git remote add origin [URL-del-repositorio]
- git clone [URL-del-repositorio]
- git add . 
- git commit -m "[mensaje]"
- git push origin [rama]