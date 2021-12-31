using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Task2
{
    class Square : Rectangle
    {
        public Square(float height, float width) : base(height, width) {
            if (height != width) {
                throw new HeightWidthDiscrepancyExeption();
            }
            setHeight(height);
            setWidth(width);
            
        }

        public Square(float sideLength) : base(sideLength, sideLength) {
            setHeight(sideLength);
            setWidth(sideLength);
        }

    }


    class HeightWidthDiscrepancyExeption : Exception
    {
        public override string Message {
            get {
                return "Squares must have equal height and width.";
            }
        }

    }
}
