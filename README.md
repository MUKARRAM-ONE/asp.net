# TaskManagerPro

**TaskManagerPro** is a comprehensive, multi-user task management application built with **ASP.NET Core MVC (net10.0)** and **Entity Framework Core**. It features a modern, responsive user interface styled with **Glassmorphism** design principles, offering a premium user experience for organizing personal and professional tasks.

## 🚀 Key Features

### 🔐 Authentication & User Management
- **Secure Access**: Cookie-based authentication system with Login, Registration, and Logout capabilities.
- **Data Isolation**: All tasks, categories, and dashboard statistics are strictly scoped to the authenticated user.
- **Personalization**:
    - **Theme Support**: Built-in Light and Dark modes, persisted via LocalStorage and server-side user preferences.
    - **User Profile**: Tracks account creation date and theme settings.

### 📊 Interactive Dashboard
The dashboard provides a real-time overview of productivity:
- **Task Statistics**: Instant counts for Total, Pending (To-Do), In-Progress, and Completed tasks.
- **Priority Breakdown**: Visual distribution of active tasks by High, Medium, and Low priority.
- **Category Insights**: Aggregated task counts per category (e.g., Work, Personal, Study).
- **Recent Activity**: Quick view of the 5 most recently created tasks.

### ✅ Task Management
Full CRUD (Create, Read, Update, Delete) capabilities with rich metadata:
- **Properties**:
    - **Title & Description**: Detailed task information.
    - **Priority**: `Low`, `Medium`, `High`.
    - **Status**: `To Do`, `In Progress`, `Done`.
    - **Due Date**: Optional deadline tracking.
    - **Categories**: Organize tasks into color-coded buckets (Work, Personal, Study, etc.).
- **Organization**:
    - Default sorting by creation date (newest first).
    - Archived state support (soft delete logic available in model).

### 🎨 Modern UI/UX
- **Glassmorphism Design**: Translucent, frosted-glass effects on cards, navbars, and containers (`glass.css`).
- **Responsive Layout**: Built on **Bootstrap 5**, ensuring seamless usage on mobile, tablet, and desktop.
- **Visual Cues**:
    - **Icons**: Font Awesome 6 integration for intuitive navigation and category representation.
    - **Fonts**: Google Fonts (**Poppins** for headers, **Inter** for body text) for excellent readability.

## 🛠 Tech Stack

- **Framework**: ASP.NET Core MVC (.NET 10.0)
- **Database**: SQL Server (via Entity Framework Core 10.0.2)
- **Frontend**:
    - Razor Views (`.cshtml`)
    - Bootstrap 5 (CSS framework)
    - jQuery & jQuery Validation (Client-side logic)
    - Font Awesome 6.4.0 (Icons)
- **Styling**: Custom CSS with Glassmorphism variables (`site.css`, `glass.css`).

## 📂 Project Structure

| Path | Description |
| :--- | :--- |
| `myweb/Program.cs` | Application entry point, dependency injection, auth configuration, and database seeding. |
| `myweb/Data/` | Contains `ApplicationDbContext` and database configuration. |
| `myweb/Models/` | Domain entities: `User`, `Task`, `Category`, plus ViewModels (`ErrorViewModel`, `AccountViewModels`). |
| `myweb/Controllers/` | MVC Controllers: `Account`, `Dashboard`, `Tasks`, `Home`. |
| `myweb/Views/` | Razor pages organized by controller. Includes Shared layouts and partials. |
| `myweb/wwwroot/` | Static assets: `css/`, `js/`, `lib/` (Bootstrap, jQuery). |
| `myweb/Migrations/` | EF Core database migration files. |
| `specs/` | Detailed feature specifications, plans, and architectural docs (SDD). |

## ⚙️ Setup & Installation

### Prerequisites
- **.NET SDK 10.0**: Required to build and run the application.
- **SQL Server**: LocalDB or a full instance.
- **EF Core Tools**: For managing database migrations (`dotnet tool install --global dotnet-ef`).

### Installation Steps

1.  **Clone the Repository**
    ```bash
    git clone https://github.com/your-repo/task-manager-pro.git
    cd web_ccp
    ```

2.  **Restore Dependencies**
    ```bash
    cd myweb
    dotnet restore
    ```

3.  **Configure Database**
    - Open `appsettings.json`.
    - Update the `DefaultConnection` string to point to your SQL Server instance.

4.  **Apply Migrations**
    Creates the database and seeds default categories (Work, Personal, Study).
    ```bash
    dotnet ef database update
    ```

5.  **Run the Application**
    ```bash
    dotnet run
    ```
    Access the app at `http://localhost:5153` (or the port specified in the output).

## 🔮 Roadmap (In Development)

The following features are specified and currently in the implementation phase:
- **Kanban Board**: Drag-and-drop task management.
- **Pomodoro Timer**: Integrated productivity timer.
- **Voice Input**: Create tasks using speech recognition.
- **Export Tools**: Export tasks to CSV/PDF.

## 📄 License
This project is licensed under the MIT License. See [LICENSE](LICENSE).