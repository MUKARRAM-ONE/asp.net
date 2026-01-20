<!--
SYNC IMPACT REPORT
Version: 0.0.0 -> 1.0.0
Modified Principles:
- Defined I. Modern Visuals & UX
- Defined II. Interactive Engagement
- Defined III. ASP.NET MVC Core
- Defined IV. Responsive & Mobile-First
- Defined V. Security & Standards
Added Sections:
- Technology Stack & Environment
- Development Workflow
Templates Updated:
- ✅ .specify/memory/constitution.md
-->

# Task Management System Constitution

## Core Principles

### I. Modern Visuals & UX
The application MUST be visually stunning, utilizing modern design trends such as glassmorphism, neumorphism, and vibrant gradients. Animations and smooth transitions are REQUIRED to create a premium, polished feel. Standard, flat CRUD interfaces are explicitly discouraged.

### II. Interactive Engagement
Every user action MUST trigger a micro-interaction or immediate visual feedback. JavaScript SHOULD be used extensively to create a dynamic, single-page-application-like feel within the MVC structure. The goal is to maximize user delight and engagement ("Wow Factor").

### III. ASP.NET MVC Core
The architecture MUST strictly follow the ASP.NET MVC pattern using C# and Entity Framework Core for data access. Separation of concerns (Models, Views, Controllers) is paramount. Business logic should reside in Services or Controllers, keeping Views focused on presentation.

### IV. Responsive & Mobile-First
The User Interface MUST be fully responsive and functional across all device sizes (Mobile, Tablet, Desktop). Bootstrap 5 is the foundational grid system, but it MUST be enhanced with custom CSS to avoid a "generic Bootstrap site" look.

### V. Security & Standards
All user inputs MUST be validated on both the client (for UX) and server (for security). Authentication, Authorization, and CSRF protection are MANDATORY. Code must follow standard C# naming conventions and web development best practices.

## Technology Stack & Environment

**Frontend**: HTML5, CSS3 (Custom + Bootstrap 5), JavaScript (ES6+), jQuery (if needed for MVC integration).
**Backend**: ASP.NET Core MVC (C#), Entity Framework Core.
**Database**: SQL Server.
**IDE**: Visual Studio Code (Primary).
**OS**: Windows (win32).

## Development Workflow

1.  **Visual First**: Design the UI/UX interaction before writing backend logic.
2.  **Iterative Polish**: Implement functionality, then immediately refine animations and feedback.
3.  **Code Quality**: Ensure clean, commented, and structured code suitable for academic evaluation.
4.  **Demonstration Focus**: Prioritize features that look impressive in a live demo.

## Governance

This Constitution serves as the primary design and architectural guide for the Task Management System.
Amendments require clear justification and must NOT compromise the visual quality or user experience goals.
All code changes must be verified against these principles before merging.

**Version**: 1.0.0 | **Ratified**: 2026-01-20 | **Last Amended**: 2026-01-20