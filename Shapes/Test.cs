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

        public void main()
        {
            A = new Square(4, 3, 4, 3);

            A.CalcPerimeter();
            A.CalcArea();

            Console.WriteLine(A.shape_type);
            Console.WriteLine(A.P);
            Console.WriteLine(A.S);

        }


    }
}
