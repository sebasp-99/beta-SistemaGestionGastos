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


**Comandos git:**
- git init
- git clone [enlace respositorio]
- git add . 
- git commit -m "[mensaje]"
- git push origin [rama]