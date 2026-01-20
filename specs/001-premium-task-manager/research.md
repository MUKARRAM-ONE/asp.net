# Research & Technology Decisions

## Frontend Libraries

### Charting: Chart.js
- **Decision**: Use Chart.js for dashboard statistics.
- **Rationale**: Lightweight, widely used, excellent animation support, easy integration with standard HTML5 Canvas.
- **Alternatives**: D3.js (too complex for simple stats), Google Charts (requires external script loading/online dependency).

### Drag and Drop: Sortable.js
- **Decision**: Use Sortable.js for the Kanban board and task reordering.
- **Rationale**: No jQuery dependency (unlike jQuery UI Sortable), touch support (critical for mobile requirement), and smooth animations.
- **Alternatives**: HTML5 Native DnD API (clunky, extensive boilerplate code needed for smooth visual feedback).

### Voice Input: Web Speech API
- **Decision**: Use native browser `webkitSpeechRecognition` / `SpeechRecognition`.
- **Rationale**: No external dependencies, zero cost, sufficiently accurate for short task titles/descriptions.
- **Constraints**: Primarily supported in Chrome/Edge/Safari. Fallback UI required for unsupported browsers (Firefox).

## UX Patterns

### Design System: Glassmorphism
- **Decision**: Custom CSS utilities over a pre-built "Glass UI" framework.
- **Rationale**: Allows precise control over blur intensity (`backdrop-filter`) and transparency to ensure accessibility (contrast) is maintained, which can be tricky with glassmorphism.

### Animations: CSS + Minimal JS
- **Decision**: Use CSS Transitions/Keyframes for hover/load states; JS only for complex sequencing (e.g., celebration confetti).
- **Rationale**: Performance (hardware acceleration), cleaner code separation.

## Backend Architecture

### API Strategy
- **Decision**: Hybrid Approach - Razor Views for initial page load (SEO, Performance), JSON API for specific interactions (DnD, Status Toggle).
- **Rationale**: Satisfies MVC requirement while delivering SPA-like interactivity.
