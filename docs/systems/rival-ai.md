# Rival AI (Arcade Racing)

## Goals
- Rivales agresivos pero “justos”
- Diferentes personalidades (drifter, blocker, sprinter)
- Rubberbanding suave (sin trampas descaradas)

## Inputs for AI
- Desired speed
- Desired steering toward path
- Overtake intent
- Avoidance (coches/obstáculos)

## States
- FollowPath
- Overtake
- Defend
- Recover (si se atasca)
- AggressiveBump (opcional)

## Pathing
Opción inicial: Waypoints ordenados.
- targetWaypointIndex
- lookAheadDistance (mira varios metros delante)
- cornerSlowdown (reduce velocidad en curva)

## Behavior
### FollowPath
- Mantener línea base
- Ajustar velocidad según curva (predictivo)

### Overtake
- Si jugador delante a X metros:
  - escoger lado libre
  - aumentar speedTarget temporalmente

### Defend
- Si AI va delante y jugador cerca:
  - cambia línea ligeramente para bloquear (no demasiado)

### Recover
- Si velocidad baja + sin progreso:
  - respawn a último checkpoint

## Difficulty Params per Rival
- maxSpeedMultiplier
- accelerationMultiplier
- aggression (0-1)
- riskTaking (0-1)
- rubberbandStrength (0-1)

## Rubberbanding (fair)
- Si AI muy atrás:
  - +maxSpeed pequeño y temporal
- Si AI muy delante:
  - reduce boost o se “equivoca” ligeramente en curva

## Fairness rules
- Nunca teleport
- Nunca ignora colisiones
- Siempre puede fallar (pero no constantemente)
