using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int NumLanes { get; set; }
        public int TrafficLevel { get; set; } 

        
        public void SimulateTraffic()
        {
            
        }
    }

    
    public class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public double Size { get; set; }
        public string Type { get; set; }

        public void Move()
        {
            
        }

        public void Stop()
        {
            
        }
    }

   
    public interface IDriveable
    {
        void Move();
        void Stop();
    }

    
    public class TrafficSimulation
    {
        private List<Vehicle> vehicles; 
        private Road road; 

        public TrafficSimulation(Road road)
        {
            this.road = road;
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SimulateTrafficMovement()
        {
            foreach (var vehicle in vehicles)
            {
                
            }
        }
    }
}