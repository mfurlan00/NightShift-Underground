using System;

namespace NightShift.Core
{
    public static class GameEvents
    {
        public static event Action OnRaceStarted;
        public static event Action OnRaceFinished;
        public static event Action<int> OnHeatChanged;

        public static void RaceStarted() => OnRaceStarted?.Invoke();
        public static void RaceFinished() => OnRaceFinished?.Invoke();
        public static void HeatChanged(int heat) => OnHeatChanged?.Invoke(heat);
    }
}
