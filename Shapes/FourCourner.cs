using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    public class FourCourner : AngleShape
    {
        public double d { get; set; }

        public FourCourner(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            valid = Validate();
            P = CalcPerimeter();

        }

        public new double CalcPerimeter()
        {
            if (valid)
            {
                return a + b + c + d;
            }
            else
            {
                return -1;
            }

        }

        public new bool Validate()
        {
            if (a > 0 && b > 0 && c > 0 && d > 0)
            {
                shape_type = "For Corner";
                return true;
            }
            else
            {
                shape_type = "For Corner Margins can't be shorter than 0 or equal";
                return false;
            }

        }

    }

    public class Square : FourCourner
    {
        public Square(double a, double b, double c, double d) : base(a, b, c, d)
        {
            S = CalcArea();
        }

        public new double CalcArea()
        {
            if (valid)
            {
                return a * a;
            }
            else
            {
                return -1;
            }

        }

    }

    public class Rectangular : FourCourner
    {
        public Rectangular(double a, double b, double c, double d) : base(a, b, c, d)
        {
            //valid = Validate();
            S = CalcArea();
        }

        public new double CalcArea()
        {
            if (valid)
            {
                return a * b;
            }
            else
            {
                return -1;
            }

        }

    }
}
