namespace PTALib.Cars
{
    public class Truck : Origin
    {
        public float MaxCapacity { get; private set; } = 1111.0f;
        public float LoadCapacity { get; private set; } = 0.0f;
        public float CargoWeight { get; set; } = 200.0f;
        public float ReduceDistancePerCargo { get; set; } = 0.04f;

        public Truck(float MaxCapacity)
        {
            this.MaxCapacity = MaxCapacity;
        }

        public override float GetRemainingDistance()
        {
            float baseRemainingDistance = base.GetRemainingDistance();
            for (float f = CargoWeight; f <= LoadCapacity; f += CargoWeight)
            {
                baseRemainingDistance -= baseRemainingDistance * ReduceDistancePerCargo;
            }
            return baseRemainingDistance;
        }

        public bool AddCargo()
        {
            if (LoadCapacity + CargoWeight > MaxCapacity)
                return false;
            LoadCapacity += CargoWeight;
            return true;
        }
    }
}