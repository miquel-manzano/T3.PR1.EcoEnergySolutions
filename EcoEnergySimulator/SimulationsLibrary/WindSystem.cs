using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class WindSystem: EnergySystem
    {
        private float windSpeed;

        public float GetWindSpeed() { return this.windSpeed; }
        public void SetWindSpeed(float windSpeed) { this.windSpeed = windSpeed; }

    }
}