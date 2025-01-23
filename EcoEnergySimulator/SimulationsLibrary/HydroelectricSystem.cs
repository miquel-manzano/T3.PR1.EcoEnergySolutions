using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class HydroelectricSystem: EnergySystem, IEnergyCalculation
    {
        private float waterFlow;

        public float GetWaterFlow() { return this.waterFlow; }
        public void SetWaterFlow(float waterFlow) { this.waterFlow = waterFlow; }

    }
}