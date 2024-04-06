namespace task_Vehicle.Models
{
    internal class Car : Vehicle
    {
        int _doorCount;
        bool _isElectricCar;


        public int DoorCount
        {
            get
            { return _doorCount; }
            set 
            {
                if(value >=1 && value < 5)
                {
                    _doorCount = value;
                }                      
           
            }
        
        }
        public bool IsElectricCar
        {
            get { return _isElectricCar; }


            set
            {
                if(value==true) 
                {
                    _isElectricCar = true;
                
                }
                 
              

            }
        
        
        }
        
        public Car(int doorCount,bool isElectrictCar, string factoryName, string model, string color, int driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElectricCar = isElectrictCar;
            
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar) 
            {
                Console.WriteLine( "low damage" );
            }
            else 
            {
                Console.WriteLine("hight damage");
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine( "Door Count: "+ _doorCount );
            DefineNatureHarmness();
        }
















    }
}
