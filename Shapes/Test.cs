using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    public class Test
    {
        public Square A;
        public Rectangular B;
        public Rhombus C;

        public void main()
        {
            A = new Square(4);

            A.CalcPerimeter();
            A.CalcArea();

            Console.WriteLine(A.shape_type);
            Console.WriteLine(A.P);
            Console.WriteLine(A.S);

            B = new Rectangular(4, 3);

            B.CalcPerimeter();
            B.CalcArea();

            Console.WriteLine(B.shape_type);
            Console.WriteLine(B.P);
            Console.WriteLine(B.S);

            C = new Rhombus(4, 3, 1);

            C.CalcPerimeter();
            C.CalcArea();

            Console.WriteLine(C.shape_type);
            Console.WriteLine(C.P);
            Console.WriteLine(C.S);

        }


    }
}
