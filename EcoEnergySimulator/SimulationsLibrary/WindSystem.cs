using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class WindSystem: EnergySystem, IEnergyCalculation
    {
        private double windSpeed;

        public double GetWindSpeed() { return this.windSpeed; }
        public void SetWindSpeed(double windSpeed) { this.windSpeed = windSpeed; }

    }
}