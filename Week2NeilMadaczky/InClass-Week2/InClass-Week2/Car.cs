using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_Week2
{
    class Car
    {
        public string make;
        public string model;
        public string color;

        public int year;
        int speed;
        int topSpeed;

        int accelerate()
        {
            speed = speed + 1;
            return speed;
        }
    }
}
