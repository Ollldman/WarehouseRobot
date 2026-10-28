// Учебные модели правил. Unity-объекты и интерфейс подключаются отдельно.
public static class MechanicModels
{
    public sealed class Delivery
    {
        public bool HasCargo { get; private set; }
        public int Delivered { get; private set; }
        public bool Pickup()
        {
            if (HasCargo) return false;
            HasCargo = true; return true;
        }
        public bool Unload()
        {
            if (!HasCargo) return false;
            HasCargo = false; Delivered++; return true;
        }
        public bool Drop()
        {
            if (!HasCargo) return false;
            HasCargo = false; return true;
        }
        public void Reset() { HasCargo = false; Delivered = 0; }
    }
}