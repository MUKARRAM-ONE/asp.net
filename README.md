# TaskManagerPro (ASP.NET Core MVC)

TaskManagerPro is a multi-user task management web app built with ASP.NET Core MVC and Entity Framework Core. It provides authentication, dashboard insights, CRUD for tasks, category organization, and light/dark theme support.

## Features
- User authentication with cookie-based login/register/logout
- Dashboard with task stats (total, completed, in-progress, pending), priority breakdown, category counts, and recent tasks
- Tasks CRUD: create, edit, delete, list (per-user) with priority, status, due date, and category
- Categories with icon/color; default seed (Work, Personal, Study)
- Light/Dark theme toggle persisted per user (and in local storage)
- Responsive UI with glassmorphism styling and bootstrap

## Tech Stack
- ASP.NET Core MVC (net10.0)
- Entity Framework Core (SQL Server provider)
- Bootstrap, Font Awesome, custom CSS/JS

## Project Structure (key paths)
- `myweb/Program.cs` – app startup, DI, auth, session, category seeding
- `myweb/Data/ApplicationDbContext.cs` – EF Core DbContext and model configuration
- `myweb/Models/` – `User`, `Task`, `Category`, auth view models
- `myweb/Controllers/` – `AccountController`, `DashboardController`, `TasksController`, `HomeController`
- `myweb/Views/` – Razor views for account, dashboard, tasks, layout, home
- `myweb/wwwroot/` – static assets (CSS, JS, bootstrap libs)
- `myweb/Migrations/` – EF Core migrations

## Prerequisites
- .NET SDK 10 (matches `TargetFramework net10.0`)
- SQL Server (local or remote). Default connection string is in `myweb/appsettings.json`.
- (Optional) `dotnet-ef` tool for running migrations:
  ```bash
  dotnet tool install --global dotnet-ef
  ```

## Setup & Run
1) Clone and restore:
   ```bash
   git clone https://github.com/MUKARRAM-ONE/asp.net.git
   cd asp.net/myweb
   dotnet restore
   ```

2) Configure database (if needed):
   - Update `ConnectionStrings:DefaultConnection` in `appsettings.json` (and `appsettings.Development.json` if you use it).

3) Apply migrations and create the database:
   ```bash
   dotnet ef database update
   ```
   (This applies the migrations under `myweb/Migrations/` and seeds default categories on startup.)

4) Run the app:
   ```bash
   dotnet run
   ```
   App will listen on the URLs from `Properties/launchSettings.json` (e.g., http://localhost:5153).

## Usage Notes
- Register a user account, then sign in. All tasks and dashboard stats are scoped to the logged-in user.
- Use the Theme button in the navbar to toggle light/dark; preference is stored per user and in local storage.
- Categories are seeded (Work, Personal, Study); you can extend via database or add a category management feature.

## Scripts Reference
- Build: `dotnet build`
- Run: `dotnet run`
- Apply migrations: `dotnet ef database update`
- Add migration (if you change models): `dotnet ef migrations add <Name>`

## License
Not specified. Add a license file if you plan to distribute.
