# README

## Sql Injection

```bash
PASSWORD="33eca922-74a0-11ee-9e21-00155d9a126b"

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$PASSWORD" -p 1433:1433 --name sql-server -d mcr.microsoft.com/mssql/server:2022-latest

dotnet user-secrets set "ConnectionStrings:ConnectionString" "Data Source=localhost,1433;Initial Catalog=SqlInjection;User=sa;Password=$PASSWORD;TrustServerCertificate=True"

dotnet ef database update
```