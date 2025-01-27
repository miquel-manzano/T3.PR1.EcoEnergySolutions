using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public abstract class EnergySystem : IEnergyCalculation
    {
        public string SystemName { get; set; }
        public DateTime SimulationDate { get; set; }


        public EnergySystem(string SystemName)
        {
            this.SystemName = SystemName;
            SimulationDate = DateTime.Now;
        }
    }
}