using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Task2
{
    class Triangle : GeometricFigure
    {
        public Triangle(float height, float width) : base(height, width) {
            setHeight(height);
            setWidth(width);
        }
        public override float computeArea()
        {
            return getHeight() * getWidth() / 2;
        }
    }
}
