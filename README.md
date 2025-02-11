Rodar migration: dotnet ef migrations add UpdateUserSeedTable -s ./WebApi/Project.WebApi.csproj -p ./Infrastructure/Project.Infrastructure.csproj -c ApplicationDbContext

atualizar banco de dados: dotnet ef database update
