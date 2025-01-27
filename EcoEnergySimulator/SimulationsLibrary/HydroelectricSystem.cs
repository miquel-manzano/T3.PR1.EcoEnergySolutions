using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class HydroelectricSystem: EnergySystem, IEnergyCalculation
    {
        private double waterFlow;

        public double GetWaterFlow() { return this.waterFlow; }
        public void SetWaterFlow(double waterFlow) { this.waterFlow = waterFlow; }

    }
}