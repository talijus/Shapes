using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
//using System.Math;

namespace LessonTwo
{
    public class Triangle : AngleShape
    {
        public Triangle (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public new double CalcPerimeter()
        {
            return a + b + c;
        }
    }

}
