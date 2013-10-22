using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    class Rectangle
    {
        private double m_length, m_width, m_area;

        public Rectangle()
        {

        }

        public Rectangle(double length, double width)
        {
            m_length = length;
            m_width = width;
        }

        public double Length
        {
            get
            {
                return m_length;
            }
            set
            {
               if (value > 0)
               {
                  m_length = value;
               }
               else
               {
                  throw new ArgumentOutOfRangeException(
                     "length", value, "Length can not be 0 or a negative number.");
               }               
            }
        }

        public double Width
        {
            get
            {
                return m_width;
            }
            set
            {
               if (value > 0)
               {
                  m_width = value;
               }
               else
               {
                  throw new ArgumentOutOfRangeException(
                     "Width", value, "Width can not be 0 or a negative number.");
               }             
            }
        }

        public double CalculateArea()
        {
            return m_area = m_length  * m_width;
        }

        public override string ToString()
        {
            return "Area: " + CalculateArea().ToString();
        }
    }
}
