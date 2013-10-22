using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    class AreaCalculatorTests
    {
       static void Main(string[] args)
       {
          try
          {
             Circle c1 = new Circle();
             c1.Radius = 5.0;
             Console.WriteLine("Circle Test" + "\nRadius: " + c1.Radius + "\n" +c1);

             Rectangle r1 = new Rectangle(3.0, 2.0);
             Console.WriteLine("\nRectangle Test"
                                + "\nLength: " + r1.Length + "\nWidth: " + r1.Width + "\n" + r1);

             Cylinder c = new Cylinder();
             c.Radius = 4.0;
             c.Height = 10;
             Console.WriteLine("\nCylinder Test"
                                + "\nRadius: " + c.Radius
                                + "\nHeight: " + c.Height
                                + "\nSurface area: " + c.CalculateArea());

             Console.ReadLine();
          }
          catch (ArgumentOutOfRangeException argE)
          {
             Console.WriteLine(argE.Message);
             Console.WriteLine("The value you entered was " + argE.ActualValue);
          }
          catch (Exception e)
          {
             Console.WriteLine(e.Message);
          }
          finally
          {
             Console.ReadLine();
          }
       }

           private string m_choose, m_choice;
           
           public string Choose
           {
               get
               {
                   return m_choose;
               }
               set
               {
                   m_choose = value;
               }
           }

           public string Choice
           {
               get
               {
                   switch (m_choice)
                   {
                      case "circle": m_choice = "A";
                         break;
                      case "rectangle": m_choice = "B";
                         break;
                      case "cylinder": m_choice = "C";
                         break;
                      default: 
                         throw new ArgumentOutOfRangeException("Invalid selection. Please choose A, B, or C.");
                   }
                   return m_choice;
               }
               set
               {
                  m_choice = value;
               }
           }
    
     }
    
}
