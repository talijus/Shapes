/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

using System;

namespace LessonTwo
{
    

    public interface IPerimeter
    {
        double CalcPerimeter();
        double P { get; set; }
    }

    public interface IArea
    {
        double CalcArea();
        double S { get; set; }
    }

    public interface IValidation
    {
        bool Validate();
        bool valid { get; set; }
    }

    public abstract class Shape : IPerimeter, IArea, IValidation
    {
        
        public string shape_type;

        public double P { get; set; }                       //  perimeter
        public double S { get; set; }                       //  area
        public bool valid { get; set; }                     //  is valid shape

        public double CalcArea() { return -1; }             //  calculate area
        public double CalcPerimeter() { return -1; }        //  calculate perimeter
        public bool Validate() { return true; }             //  validate shape
    }


    //  shape without corners
    public class RoundShape : Shape
    {
        public double r { get; set; }                       //  radius, at least one is required
    }


    //  shape with corners
    public class AngleShape : Shape
    {   // at least 3 corners or marginals is required
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
    }
}
