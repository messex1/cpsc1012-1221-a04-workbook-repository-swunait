using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    public class Rectangle
    {
        // Define a fully-implemented properties for the Length of the Rectangle
        // Fully-implemented property is required when you need to validate the new value in the mutator
        // To define a fully-implemented property
        //  1) Define a data field for the property
        //  2) Define a property to encapsulate access to the data field

        // Step 1: Define a data field for the property
        private double _length;

        // Step 2: Define a property to encapsulate access to the data field
        public double Length
        {
            get // accessor
            {
                return _length;
            }
            set // mutator
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than zero");
                }
                _length = value;
            }
        }

        // Define a auto-implemented property for the Width of the Rectange
        // Auto-implemented property are used when you do NOT need to validate the new value being assign in the mutator
        public double Width { get; set; }

        // Define a constructor to initialze the data fields or properties with meaningful values
        public Rectangle(double length, double width)
        {
            // Assigned the method parameters to the properties
            Length = length;
            Width = width;
        }

        // Define instance-level methods that perform operations using the properties of the object
        public double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return 2 * (Length + Width);
        }

    }
}
