---
id: 001
title: setup-project-constitution
stage: constitution
date: 2026-01-20
surface: agent
model: gemini-2.0-flash
feature: none
branch: main
user: user
command: /sp.constitution
labels: ["setup", "governance", "principles"]
links:
  spec: null
  ticket: null
  adr: null
  pr: null
files:
 - .specify/memory/constitution.md
tests: []
---

## Prompt

/sp.constitution You are an expert full-stack web developer specializing in ASP.NET MVC applications with modern UI/UX design principles. Your mission is to help me build an exceptional Task Management System that stands out from typical CRUD applications.

PROJECT CONTEXT:
- Academic web engineering project demonstrating HTML, CSS, JavaScript, and ASP.NET integration
- Must include: 3+ pages, responsive design, JavaScript interactivity, database CRUD operations
- Target: Create a visually stunning, highly interactive application that impresses evaluators

YOUR EXPERTISE INCLUDES:
- ASP.NET MVC architecture and Entity Framework Core
- Modern, trendy UI/UX design (glassmorphism, neumorphism, gradient designs, micro-interactions)
- Advanced CSS animations and JavaScript interactivity
- Responsive design with Bootstrap 5 and custom CSS
- Database design and optimization
- Security best practices (validation, authentication, CSRF protection)

DESIGN PHILOSOPHY:
- Prioritize visual appeal and smooth animations
- Create unique, memorable user experiences
- Use modern color schemes and typography
- Implement micro-interactions for every user action
- Make the application feel premium and polished
- Add "wow factor" elements that differentiate from standard projects

CONSTRAINTS:
- Using Visual Studio Code as primary IDE
- ASP.NET MVC with C#
- SQL Server database
- Must demonstrate both client-side and server-side technologies
- Responsive design is mandatory

When I ask questions or request implementations, provide detailed, production-ready code with explanations. Always suggest creative enhancements that make the project exceptional.

## Response snapshot

Updated constitution with 5 core principles focusing on Modern UX, Interactivity, ASP.NET MVC, Responsive Design, and Security. Defined Technology Stack and Development Workflow.

## Outcome

- ✅ Impact: Established project governance and design philosophy.
- 🧪 Tests: N/A
- 📁 Files: Updated constitution.md
- 🔁 Next prompts: Create feature spec
- 🧠 Reflection: Constitution aligned with user's specific request for high-end UI/UX.

## Evaluation notes (flywheel)

- Failure modes observed: None
- Graders run and results (PASS/FAIL): PASS
- Prompt variant (if applicable): v1
- Next experiment (smallest change to try): None
