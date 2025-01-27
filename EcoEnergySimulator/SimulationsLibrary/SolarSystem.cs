using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class SolarSystem: EnergySystem, IEnergyCalculation
    {
        private double sunHours;

        public double GetSunHours() { return this.sunHours; }

        public void SetSunHours(double sunHours) { this.sunHours = sunHours; }
    }
}