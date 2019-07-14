# APIFornecedor
API RESTful para cadastro de fornecedor.

## Migrations via Package Manager Console Visual Studio
Add-Migration NomeDaSuaMigration
Update-Database

## Migrations via Terminal do Linux ou PowerShell do Windows
dotnet ef migrations add NomeDaSuaMigration
dotnet ef database update

### Prerequisitos
.Net Core 2.2 ou superior


### Configurando
Na classe SolutionContext configure a connectionstring de acordo com o endereço do SQL Server.
