using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieApp
{
    public class Die
    {
        // Define data fields for storing data or for internal usage
        private int _sides;     // number of sides for Die
        private int _faceValue; // current face value of Die 
        private Random _random = new Random();  // internal usage for generatig random numbers

        // Define properties to encapsulate access to the data fields
        public int Sides
        {
            get // accessor
            {
                return _sides;
            }
        }
        public int Value
        {
            get // accessor
            {
                return _faceValue;
            }
        }

        // Define constructors to initialze the data fields with meaningful values
        public Die(int numSides)
        {
            // Assign method parameters to either data field or property
            // Assign method parameter to data field for read only properties
            // otherwise assign method parameter to property 
            _sides = numSides;

            Roll();
        }

        // Define instance-level methods that perform operations using the data fields
        public void Roll()
        {
            //_faceValue = _random.Next(1, Sides + 1);
            _faceValue = _random.Next(1, _sides + 1);
        }

    }
}
