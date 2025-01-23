using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class SolarSystem: EnergySystem, IEnergyCalculation
    {
        private float sunHours;

        public float GetSunHours() { return this.sunHours; }

        public void SetSunHours(float sunHours) { this.sunHours = sunHours; }
    }
}