namespace PTALib.Cars
{
    public class Light : Origin
    {
        public int Passengers { get; private set; } = 0;
        public int MaxPassengers { get; set; } = 3;
        private float ReduceDistancePerPassenger { get; set; } = 0.06f;

        public override float GetRemainingDistance()
        {
            float baseRemainingDistance = base.GetRemainingDistance();

            for (int i = 0; i < Passengers; i++)
            {
                baseRemainingDistance -= baseRemainingDistance * ReduceDistancePerPassenger;
            }

            return baseRemainingDistance;
        }
        public bool AddPassenger()
        {
            if (Passengers >= MaxPassengers)
                return false;
            Passengers++;
            return true;
        }
    }
}