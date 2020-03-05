# APIFornecedor
API RESTful para cadastro de fornecedor.

### Diagrama de classes das entidades

![N|Solid](https://i.ibb.co/4S4Sndb/uml-api.jpg)

### Migrations - Package Manager Console
```
Add-Migration NomeDaSuaMigration
Update-Database
```

### Migrations - Terminal
```
dotnet ef migrations add NomeDaSuaMigration
dotnet ef database update
```

### Pré requisitos
```
.Net Core 2.2 ou superior
```

### Configurando
```
Na classe SolutionContext configure a connectionstring de acordo com o endereço do SQL Server.
```
