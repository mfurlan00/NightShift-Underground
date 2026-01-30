using System;

namespace NightShift.Core
{
    public class GameStateMachine
    {
        public GameState CurrentState { get; private set; }

        public event Action<GameState, GameState> OnStateChanged;

        public void SetState(GameState newState)
        {
            if (newState == CurrentState) return;

            GameState previous = CurrentState;
            CurrentState = newState;

            OnStateChanged?.Invoke(previous, newState);
        }
    }
}
