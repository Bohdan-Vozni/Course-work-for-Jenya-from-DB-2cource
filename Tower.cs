namespace jenya_lab_7
{
    public class Tower
    {
        public string Tower_ID { get; set; }
        public string Title { get; set; }
        public string TypeSize { get; set; }
        public string FanType { get; set; }
        public string FanIncluded { get; set; }
        public float Cost { get; set; }
    }

    public class Bluetooth
    {
        public string Bluetooth_ID { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public float Cost { get; set; }
    }

    public class Wifi
    {
        public string Wifi_ID { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public float Cost { get; set; }
    }

    public class FanCooling
    {
        public string FanCooling_ID { get; set; }
        public string Title { get; set; }
        public string TypeSize { get; set; }
        public string HeatRemoval { get; set; }
        public float Cost { get; set; }
    }

    public class WaterCooling
    {
        public string WaterCooling_ID { get; set; }
        public string Title { get; set; }
        public string TypeSize { get; set; }
        public string HeatRemoval { get; set; }
        public float Cost { get; set; }
    }

    public class PowerSupply
    {
        public string PowerSupply_ID { get; set; }
        public string Title { get; set; }
        public string Strength { get; set; }
        public string Sertificate { get; set; }
        public float Cost { get; set; }
    }

    public class SSD
    {
        public string SSD_ID { get; set; }
        public string Title { get; set; }
        public string MemoryQuantity { get; set; }
        public string ReadingSpeed { get; set; }
        public string WriteSpeed { get; set; }
        public string RadiatorType { get; set; }
        public float Cost { get; set; }
    }

    public class HDD
    {
        public string HDD_ID { get; set; }
        public string Title { get; set; }
        public string MemoryQuantity { get; set; }
        public string ReadingSpeed { get; set; }
        public string WriteSpeed { get; set; }
        public float Cost { get; set; }
    }

    public class RAM
    {
        public string RAM_ID { get; set; }
        public string Title { get; set; }
        public string MemoryType { get; set; }
        public string MemoryQuantity { get; set; }
        public string RadiatorType { get; set; }
        public float Cost { get; set; }
    }

    public class Motherboard
    {
        public string Motherboard_ID { get; set; }
        public string Title { get; set; }
        public string Chipset { get; set; }
        public string TypeSize { get; set; }
        public string Socket { get; set; }
        public float Cost { get; set; }
    }

    public class GPU
    {
        public string GPU_ID { get; set; }
        public string Title { get; set; }
        public string Cores { get; set; }
        public string Threads { get; set; }
        public string VRAMType { get; set; }
        public string VRAMQuantity { get; set; }
        public string Cache { get; set; }
        public string Clock { get; set; }
        public float Cost { get; set; }
    }

    public class CPU
    {
        public string CPU_ID { get; set; }
        public string Title { get; set; }
        public string Cores { get; set; }
        public string Threads { get; set; }
        public string Cache { get; set; }
        public string Clock { get; set; }
        public string Architecture { get; set; }
        public float Cost { get; set; }
    }

    public class Specialist
    {
        public string Specialist_ID { get; set; }
        public string SpecialistName { get; set; }
        public string Phone { get; set; }
    }

    public class Client
    {
        public string Client_ID { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string HomeAddress { get; set; }
    }


}
