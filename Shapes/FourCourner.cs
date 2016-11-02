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

            //valid = Validate();

            //P = CalcPerimeter();
            //S = CalcArea();
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
        public Square(double a, double b = 0, double c = 0, double d = 0) : base(a, b, c, d)
        {
            this.a = a;
            this.b = a;
            this.c = a;
            this.d = a;

            valid = Validate();

            S = CalcArea();
            P = CalcPerimeter();
        }

        public new bool Validate()
        {
            if (a > 0)
            {
                shape_type = "Square";
                return true;
            }
            else
            {
                shape_type = "Not valid Square";
                return false;
            }
            
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
        public Rectangular(double a, double b, double c = 0, double d = 0) : base(a, b, c, d)
        {
            this.c = a;
            this.d = b;

            valid = Validate();

            S = CalcArea();
            P = CalcPerimeter();
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

    public class Rhombus : FourCourner
    {
        public double h1;
        public double h2;

        public Rhombus(double a, double h1, double h2, double b = 0, double c = 0, double d = 0) : base(a, b, c, d)
        {
            this.a = a;
            this.b = a;
            this.c = a;
            this.d = a;

            this.h1 = h1;
            this.h2 = h2;

            valid = Validate();

            S = CalcArea();
            P = CalcPerimeter();
        }

        public new bool Validate()
        {
            if (a > 0 && h1 > 0 && h2 > 0 && h1 < 2 * a && h2 < 2 * a)
            {
                shape_type = "Rhombus";
                return true;
            }
            else
            {
                shape_type = "Not valid Rhombus";
                return false;
            }
        }

        public new double CalcArea()
        {
            if (valid)
            {
                return (h1 * h2) / 2;
            }
            else
            {
                return -1;
            }
        }
    }


}
