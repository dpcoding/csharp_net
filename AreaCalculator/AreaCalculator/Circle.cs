using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    class Circle
    {
        private double m_radius, m_area;
        private const double Pi = 3.14;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            m_radius = radius;
        }

        public double Radius
        {
            get
            {
                return m_radius;
            }
            set
            {
               if (value > 0)
               {
                  m_radius = value;
               }
               else
               {
                  throw new ArgumentOutOfRangeException(
                     "Radius", value, "Radius can not be 0 or a negative number.");
               }        
            }
        }

        public double CalculateArea()
        {
            return m_area = Pi * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Area: " + CalculateArea().ToString();
        }
    }
}
