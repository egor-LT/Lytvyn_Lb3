using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3
{
    public class LivingOrganism
    {
        public int Energy { get; set; }
        public int Age { get; set; }
        public int Size { get; set; }
    }

   
    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        
        public string Species { get; set; }

        public void Reproduce()
        {
            
        }

        public void Hunt(LivingOrganism prey)
        {
            
        }
    }

    public class Plant : LivingOrganism, IReproducible
    {
        
        public string Type { get; set; }

        public void Reproduce()
        {
            
        }
    }

    public class Microorganism : LivingOrganism, IReproducible, IPredator
    {
        
        public string Strain { get; set; }

        public void Reproduce()
        {
            
        }

        public void Hunt(LivingOrganism prey)
        {
          
        }
    }

    
    public interface IReproducible
    {
        void Reproduce();
    }

    public interface IPredator
    {
        void Hunt(LivingOrganism prey);
    }

 
    public class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcology()
        {

            foreach (var organism in organisms)
            {
               
            }
        }
    }
}
