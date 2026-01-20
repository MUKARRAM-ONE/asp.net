# Quickstart

## Prerequisites
- .NET 10.0 SDK (or compatible standard SDK as per project)
- SQL Server LocalDB (standard with Visual Studio/VS Code C# Dev Kit)

## Setup

1. **Clone & Restore**
   ```bash
   git clone <repo>
   cd web_ccp/myweb
   dotnet restore
   ```

2. **Database Init**
   Ensure `appsettings.json` points to your local SQL instance.
   ```bash
   dotnet ef database update
   ```

3. **Run**
   ```bash
   dotnet run
   ```
   Open `https://localhost:7000` (or configured port).

## Development
- **Watch Mode**: `dotnet watch run` for hot reloading (backend & views).
- **CSS/JS**: Edit files in `wwwroot`. No build step required for vanilla JS/CSS unless Sass is introduced.
