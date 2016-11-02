using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    public class Circle : RoundShape
    {
        public Circle (double r)
        {
            this.r = r;
        }
    }

    public class Ellipse : RoundShape
    {
        public double r2 { get; set; }

        public Ellipse (double r, double r2)
        {
            this.r = r;
            this.r2 = r2;
        }

    }
}
