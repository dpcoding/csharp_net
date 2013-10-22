using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripClassLibrary
{
    public class Trip
    {
        public double m_distance;
        public decimal m_gasCost;
        public double m_gallons;

        // default constructors
        public Trip()
        {

        }

        public Trip(double distance, decimal gasCost, double gallons)
        {
           m_distance = distance;
           m_gasCost = gasCost;
           m_gallons = gallons;
        }

       //Properties
        public double Distance
        {
           get
           {
              return m_distance;
           }
           set
           {
              m_distance = value;
           }
        }

        public decimal GasCost
        {
           get
           {
              return m_gasCost;
           }
           set
           {
              m_gasCost = value;
           }
        }

        public double Gallons
        {
           get
           {
              return m_gallons;
           }
           set
           {
              m_gallons = value;
           }
        }
       /*
        public decimal CostPerMile()
        {
           get
           {
              return m_gasCost/CalculateMilesPerGallon;
           }
        }
         */
         // methods
        public double CalculateMilesPerGallon()
        {
           return m_distance / m_gallons;
        }

        public decimal CalculateCostPerMile()
        {
           return (decimal)CalculateMilesPerGallon() / m_gasCost;
        }

        public override string ToString()
        {
           return "Distance Traveled: " +
              m_distance +
              "\nTotal Cost of Gasoline: " +
              m_gasCost.ToString("c") +
              "\nGallons Consumed: " +
              m_gallons +
              "\nMiles Per Gallons: " +
              CalculateMilesPerGallon().ToString("f1") +
              "\nCost Per Mile: " +
              CalculateCostPerMile().ToString("c");
        }

    }
}
