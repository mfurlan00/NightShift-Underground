namespace NightShift.Police
{
    public class HeatModel
    {
        public int HeatLevel { get; private set; }

        public void Increase(int amount)
        {
            HeatLevel = Clamp(HeatLevel + amount, 0, 5);
        }

        public void Decrease(int amount)
        {
            HeatLevel = Clamp(HeatLevel - amount, 0, 5);
        }

        private int Clamp(int v, int min, int max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }
    }
}
