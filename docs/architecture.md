# Architecture – NightShift: Underground

## Layers
- Core: game flow, states, bootstrap
- Vehicles: car logic, stats, tuning
- Camera: all camera behaviours
- AI: rivals behaviour
- Police: heat & pursuit systems
- UI: HUD, menus, debug

## Design Principles
- One responsibility per class
- No static abuse (except constants)
- Data-driven systems (ScriptableObjects)
- Avoid logic in Update when possible

## Naming
- MonoBehaviours: PascalCase
- Variables: camelCase
- ScriptableObjects: *Data suffix
