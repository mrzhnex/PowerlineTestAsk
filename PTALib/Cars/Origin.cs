namespace PTALib.Cars
{
    public class Origin
    {
        protected float FuelUsage { get; set; } = 2.0f;
        public float FuelMax { get; set; } = 100.0f;
        public float Speed { get; set; } = 50.0f;
        public float FuelCurrent { get; set; } = 0.0f;

        public float GetMaxDistance()
        {
            return FuelMax / GetFuelUsage() * Speed;
        }
        public virtual float GetRemainingDistance()
        {
            return FuelCurrent / GetFuelUsage() * Speed;
        }
        public float GetDrivingTime(float fuel, float distance, out float missingFuel)
        {
            missingFuel = 0.0f;
            float hours = distance / Speed;            
            
            if (fuel < hours * GetFuelUsage())
            {
                missingFuel = hours * GetFuelUsage() - fuel;
            }

            return hours;
        }
        public float GetFuelUsage()
        {
            return FuelUsage;
        }      
    }
}