# Git Workflow (Team)

## Branch Strategy
- main: estable (releases)
- develop: integración
- feature/*: nuevas features
- fix/*: hotfixes

## Naming Examples
feature/core-driving-controller
feature/camera-follow
feature/drift-system
feature/rival-ai-waypoints
feature/police-heat-v1

## Commit Style
type: message
- chore: tooling, configs
- docs: documentation
- core: architecture
- feature: gameplay
- fix: bug fix
- refactor: restructure

## PR Rules
- 1 feature = 1 PR
- No PR gigante
- Checklist:
  - build ok
  - no new warnings
  - docs updated

## Milestones & Issues
- Each milestone = phase
- Issues small & testable
- Use labels:
  - P0/P1/P2
  - system (vehicle/camera/ai/police/ui)
  - status (blocked/in-progress)

## Definition of Done
- Implementation complete
- Acceptance criteria met
- Documentation updated
- No obvious tech debt added
