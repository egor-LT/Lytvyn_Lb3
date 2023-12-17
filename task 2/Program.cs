using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string OperatingSystem { get; set; }
    }

    
    public class Server : Computer, IConnectable
    {
        public int MaxConnections { get; set; }

        public void Connect(Computer target)
        {
            Console.WriteLine($"Connected to computer with IP: {target.IPAddress}");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Disconnected from computer with IP: {target.IPAddress}");
        }

        public void SendData(Computer target, string data)
        {
            Console.WriteLine($"Data sent to computer with IP: {target.IPAddress}. Data: {data}");
        }

        public void ReceiveData(Computer source, string data)
        {
            Console.WriteLine($"Data received from computer with IP: {source.IPAddress}. Data: {data}");
        }
    }

    public class Workstation : Computer, IConnectable
    {
        public string Department { get; set; }

        public void Connect(Computer target)
        {
            Console.WriteLine($"Connected to computer with IP: {target.IPAddress}");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Disconnected from computer with IP: {target.IPAddress}");
        }

        public void SendData(Computer target, string data)
        {
            Console.WriteLine($"Data sent to computer with IP: {target.IPAddress}. Data: {data}");
        }

        public void ReceiveData(Computer source, string data)
        {
            Console.WriteLine($"Data received from computer with IP: {source.IPAddress}. Data: {data}");
        }
    }

    public class Router : Computer, IConnectable
    {
        public List<Computer> ConnectedComputers { get; set; }

        public Router()
        {
            ConnectedComputers = new List<Computer>();
        }

        public void Connect(Computer target)
        {
            ConnectedComputers.Add(target);
            Console.WriteLine($"Connected to computer with IP: {target.IPAddress}");
        }

        public void Disconnect(Computer target)
        {
            ConnectedComputers.Remove(target);
            Console.WriteLine($"Disconnected from computer with IP: {target.IPAddress}");
        }

        public void SendData(Computer target, string data)
        {
            Console.WriteLine($"Data sent to computer with IP: {target.IPAddress}. Data: {data}");
        }

        public void ReceiveData(Computer source, string data)
        {
            Console.WriteLine($"Data received from computer with IP: {source.IPAddress}. Data: {data}");
        }
    }

    
    public interface IConnectable
    {
        void Connect(Computer target);
        void Disconnect(Computer target);
        void SendData(Computer target, string data);
        void ReceiveData(Computer source, string data);
    }

   
    public class Network
    {
        private List<Computer> computers;

        public Network()
        {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void ConnectComputers(Computer computer1, Computer computer2)
        {
           
        }

        public void DisconnectComputers(Computer computer1, Computer computer2)
        {
           
        }

        public void TransferData(Computer source, Computer destination, string data)
        {
            
        }
    }
}
