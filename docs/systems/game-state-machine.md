# Game State Machine

## Goal
Controlar flujo del juego sin caos: menús, free roam, eventos, carreras, policía.

## States
- Boot
- MainMenu
- Loading
- FreeRoam
- EventIntro
- RaceCountdown
- RaceRunning
- RaceResults
- Pursuit (puede coexistir como sub-state)
- Busted (arrestado)
- Pause

## Transitions
Boot → MainMenu
MainMenu → Loading → FreeRoam

FreeRoam → EventIntro (al iniciar evento)
EventIntro → RaceCountdown
RaceCountdown → RaceRunning
RaceRunning → RaceResults
RaceResults → FreeRoam

FreeRoam/RaceRunning → Pursuit (si heat activa)
Pursuit → FreeRoam (si escapas)
Pursuit → Busted (si te atrapan)

Any → Pause (ESC)
Pause → return previous state

## Events (signals)
- OnRaceStarted
- OnRaceFinished
- OnHeatChanged
- OnPursuitStarted
- OnPursuitEnded
- OnBusted

## Responsibilities
- State machine: solo transiciones y coordinación
- Cada sistema (car/police/ai/ui) escucha eventos y actúa
