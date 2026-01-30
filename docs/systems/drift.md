# Drift System (Arcade)

## Goal
Drift fácil de iniciar, controlable, con recompensa (boost/reputation), estilo arcade nocturno.

## Inputs
- DriftKey (handbrake) = iniciar derrape y reducir grip
- Steering = controla ángulo y estabilidad
- Throttle = mantiene derrape

## States
- Normal
- DriftEntry (0.2s) → transición al derrape
- Drifting (activo)
- DriftExit (recuperación grip)

## Core Variables
- grip (normal lateral grip)
- driftGrip (lateral grip en drift)
- driftEntryBoost (impulso pequeño al iniciar)
- driftSteerAssist (ayuda a orientar el coche)
- driftStability (reduce spin-out)
- minSpeedToDrift (no drift parado)
- maxDriftAngle (limitar para evitar trompos)
- driftScoreRate (puntos por segundo)

## Mechanics
### Drift Entry
- Requiere speed >= minSpeedToDrift
- Al pulsar DriftKey:
  - grip pasa hacia driftGrip (lerp rápido)
  - se aplica driftEntryBoost leve (sensación de “enganche”)

### Drifting
- Mientras DriftKey o condiciones:
  - grip = driftGrip
  - se permite más yaw (giro)
  - se aplica driftStability para evitar 360 involuntario

### Exit
- Al soltar DriftKey o baja de velocidad:
  - grip vuelve a normal (lerp suave)
  - se “endereza” ligeramente para evitar zigzag

## Rewards (future)
- DriftPoints → nitro gain
- DriftStyle → reputación en eventos ilegales

## Fail conditions
- Si velocidad < minSpeedToDrift por X segundos → exit
- Si derrape excede maxDriftAngle → reduce control / penaliza
