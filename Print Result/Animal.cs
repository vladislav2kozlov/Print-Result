using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_Result
{
    public class Animal
    {
        public Animal ()
        {
            Classification = AnimalType.Unknown;
        }
        public AnimalType Classification { get; set; }
        private int _myInteger;
        public int MyInteger
        {
            
            get
            {
                if (_myInteger > 5)
                {
                    return _myInteger;
                }
                return 0;

            }
            set
            {
                _myInteger = value;
            }
        }
    }
}