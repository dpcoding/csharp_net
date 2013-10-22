using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    class Cylinder
    {
        private double m_radius, m_height, m_area;
        private const double Pi = 3.14;

        public Cylinder()
        {

        }

        public Cylinder(double radius, double height)
        {
            m_radius = radius;
            m_height = height;
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

        public double Height
        {
            get
            {
                return m_height;
            }
            set
            {
               if (value > 0)
               {
                  m_height = value;
               }
               else
               {
                  throw new ArgumentOutOfRangeException(
                     "Height", value, "Height can not be 0 or a negative number.");
               }      
            }
        }

        public double CalculateArea()
        {
            return m_area = (Pi * Math.Pow(Radius, 2)) * m_height;
        }

        public override string ToString()
        {
            return "Area: " + CalculateArea().ToString();
        }
    }
}
