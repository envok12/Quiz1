using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Force
    {
        private const double g = 0.0000000000667408;
        private double mass1 = 0.0;
        private double mass2 = 0.0;
        private double distance = 0.0;
        private double gravitationalForce = 0.0;

        public double MassOfObject1
        {
            get
            {
                return mass1;
            }
            set
            {
                mass1 = value;
                Calc();

            }
        }

        public double MassOfObject2
        {
            get
            {
                return mass2;
            }
            set
            {
                mass2 = value;
                Calc();
            }
        }

        public double DistanceBetweenObjects
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                Calc();

            }
        }

        public double GravitationalForce
        {
            
            get
            {
                return gravitationalForce;
            }
            private set
            {
                gravitationalForce = value;
            }
            
        }

        private void Calc()
        {

            gravitationalForce = g * (mass1 * mass2) / (distance * distance);
        }
    }
}
