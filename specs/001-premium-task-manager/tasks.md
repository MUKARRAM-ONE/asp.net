---
description: "Task list for Premium Task Management System implementation"
---

# Tasks: Premium Task Management System

**Input**: Design documents from `/specs/001-premium-task-manager/`
**Prerequisites**: plan.md, spec.md, data-model.md, contracts/

**Tests**: Manual testing scenarios defined per phase.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [ ] T001 Initialize MVC project and install dependencies (EF Core, Bootstrap) in myweb/
- [ ] T002 [P] Configure appsettings.json with connection string and logging
- [ ] T003 [P] Setup static asset folder structure in wwwroot/ (css/, js/, lib/)
- [ ] T004 Create shared layout with Glassmorphism container in Views/Shared/_Layout.cshtml
- [ ] T005 [P] Define custom CSS variables for gradients and theming in wwwroot/css/site.css
- [ ] T006 [P] Add Font Awesome and Google Fonts (Poppins/Inter) to layout head

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [ ] T007 Create User entity model in Models/User.cs
- [ ] T008 [P] Create Category entity model in Models/Category.cs
- [ ] T009 [P] Create Task entity model in Models/Task.cs
- [ ] T010 Setup ApplicationDbContext with DbSet and relationships in Data/ApplicationDbContext.cs
- [ ] T011 Create and run EF Core migrations to initialize database
- [ ] T012 Implement AuthController with Login/Register actions in Controllers/AuthController.cs
- [ ] T013 Create Login and Register views with validation in Views/Auth/
- [ ] T014 Configure Authentication middleware in Program.cs
- [ ] T015 Create DbInitializer to seed default Categories and Users in Data/DbInitializer.cs

**Checkpoint**: Database ready, Auth working, core models available.

---

## Phase 3: User Story 1 - Feature-Rich Dashboard Access (Priority: P1) 🎯 MVP

**Goal**: Dashboard with statistics and quick actions

**Independent Test**: Login -> Dashboard loads -> Stats correct -> Charts render

### Implementation for User Story 1

- [ ] T016 [US1] Create DashboardController with Index action in Controllers/DashboardController.cs
- [ ] T017 [P] [US1] Create DashboardViewModel for stats transfer in Models/ViewModels/DashboardViewModel.cs
- [ ] T018 [US1] Implement stats calculation logic (Total, Pending, Completed) in DashboardController.cs
- [ ] T019 [US1] Create API endpoint for JSON stats in Controllers/ApiController.cs (GET /api/tasks/stats)
- [ ] T020 [US1] Create Dashboard View structure in Views/Dashboard/Index.cshtml
- [ ] T021 [P] [US1] Style statistics cards with Glassmorphism in wwwroot/css/glass.css
- [ ] T022 [US1] Integrate Chart.js for completion rates in wwwroot/js/charts.js
- [ ] T023 [US1] Add "Quick Action" buttons to Dashboard view
- [ ] T024 [P] [US1] Add skeleton loading states for charts in Views/Dashboard/Index.cshtml

**Checkpoint**: User can login and see a visualized dashboard of their data.

---

## Phase 4: User Story 2 - Task Lifecycle Management (Priority: P1)

**Goal**: Full CRUD for Tasks with Filters

**Independent Test**: Create Task -> See in List -> Filter List -> Edit Task -> Delete Task

### Implementation for User Story 2

- [ ] T025 [P] [US2] Create TasksController with standard CRUD actions in Controllers/TasksController.cs
- [ ] T026 [P] [US2] Create Task Create/Edit Modal form in Views/Tasks/_TaskForm.cshtml
- [ ] T027 [US2] Implement Server-side validation for Task inputs in Controllers/TasksController.cs
- [ ] T028 [US2] Create Task List view with filtering sidebar in Views/Tasks/Index.cshtml
- [ ] T029 [US2] Implement Filter/Sort logic in TasksController.cs (Index action parameters)
- [ ] T030 [P] [US2] Create AJAX service for task operations in wwwroot/js/tasks.js
- [ ] T031 [US2] Implement Search functionality with live filtering in wwwroot/js/tasks.js
- [ ] T032 [US2] Create Toast notification system for CRUD feedback in wwwroot/js/site.js
- [ ] T033 [US2] Add animation classes for list entry/exit in wwwroot/css/animations.css

**Checkpoint**: Fully functional Task Manager.

---

## Phase 5: User Story 3 - Productivity & Engagement Tools (Priority: P2)

**Goal**: Kanban, Pomodoro, and Voice Input

**Independent Test**: Drag task in Kanban -> Status changes; Start Timer -> Counts down; Voice Input -> Text appears

### Implementation for User Story 3

- [ ] T034 [US3] Create Kanban Board view section in Views/Tasks/Index.cshtml
- [ ] T035 [US3] Initialize Sortable.js for Kanban columns in wwwroot/js/tasks.js
- [ ] T036 [US3] Implement API endpoint for drag-and-drop status updates in Controllers/ApiController.cs
- [ ] T037 [US3] Create Pomodoro Timer modal component in Views/Shared/_PomodoroModal.cshtml
- [ ] T038 [P] [US3] Implement Timer JavaScript logic (Start/Stop/Reset) in wwwroot/js/site.js
- [ ] T039 [US3] Implement Web Speech API integration for task title input in wwwroot/js/tasks.js
- [ ] T040 [US3] Add "Celebration" confetti animation for completed tasks in wwwroot/js/animations.js
- [ ] T041 [US3] Create CSV/PDF Export action in Controllers/TasksController.cs

**Checkpoint**: Advanced "Premium" features active.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final UI/UX refinements and testing

- [ ] T042 [P] Implement Dark Mode toggle logic in wwwroot/js/site.js
- [ ] T043 Update all CSS components to support Dark Mode variables in wwwroot/css/site.css
- [ ] T044 Verify mobile responsiveness (Hamburger menu, Card stacking)
- [ ] T045 Run Lighthouse accessibility audit and fix ARIA labels
- [ ] T046 Optimize image assets and enable compression
- [ ] T047 Create README.md with setup instructions and screenshots
- [ ] T048 [P] Record demo video walkthrough

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: Can start immediately.
- **Foundational (Phase 2)**: Depends on Setup. BLOCKS all user stories.
- **US1 (Phase 3)**: Depends on Foundational.
- **US2 (Phase 4)**: Depends on Foundational. Can run parallel to US1.
- **US3 (Phase 5)**: Depends on US2 (needs Task CRUD).
- **Polish (Phase 6)**: Depends on all stories.

### Parallel Opportunities

- **Frontend/Backend**: Frontend styles (T005, T021) can be developed alongside Backend Controllers (T016, T025).
- **US1 & US2**: Dashboard (Read-Only stats) and Task CRUD (Write operations) are largely independent once the Data Model is set.

## Implementation Strategy

1. **Foundation**: Get the Database and Auth working first.
2. **MVP**: Build the Task List (US2) functionality. *Note: Swapping US1 and US2 order in execution might be easier (Build CRUD -> Then Visualize it), but Dashboard is P1 MVP for "Premium" feel.*
3. **Enhance**: Add Dashboard (US1) visualization.
4. **Differentiate**: Add Kanban/Pomodoro (US3).
5. **Polish**: Finalize animations and Dark Mode.
