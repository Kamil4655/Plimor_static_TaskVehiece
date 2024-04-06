namespace task_Vehicle.Models
{
    internal class Bicycle : Vehicle
    {
         string _type;

        public Bicycle(string type,string factoryName, string model, string color, int driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {
            tyPe = type;
        }

        public string tyPe { get { return _type; } set { _type = value; } }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("none damage");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(_type +" bike");
            DefineNatureHarmness();
        }
    }
}
