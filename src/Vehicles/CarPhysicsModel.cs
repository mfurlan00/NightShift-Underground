namespace NightShift.Vehicles
{
    public class CarPhysicsModel
    {
        public float speed;
        public float maxSpeed;
        public float acceleration;

        public void Accelerate(float input, float deltaTime)
        {
            speed += input * acceleration * deltaTime;
            if (speed > maxSpeed)
                speed = maxSpeed;
        }
    }
}
