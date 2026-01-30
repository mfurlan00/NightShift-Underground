namespace NightShift.Vehicles
{
    public class CarPhysicsModel
    {
        public float speed;
        public float heading;

        public float maxSpeed;
        public float acceleration;
        public float grip;
        public float driftGrip;

        public void UpdatePhysics(CarInputModel input, float deltaTime)
        {
            // Acceleration
            speed += input.throttle * acceleration * deltaTime;
            speed = Clamp(speed, -maxSpeed * 0.5f, maxSpeed);

            // Steering (simplificado)
            float steerStrength = input.drift ? driftGrip : grip;
            heading += input.steer * steerStrength * deltaTime;
        }

        private float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
