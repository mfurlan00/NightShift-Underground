namespace NightShift.Vehicles
{
    public struct CarInputModel
    {
        public float throttle;   // -1 to 1
        public float steer;      // -1 to 1
        public bool brake;
        public bool drift;
        public bool nitro;
    }
}
