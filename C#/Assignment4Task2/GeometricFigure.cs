using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Task2
{
    abstract class GeometricFigure
    {
        private float height;
        private float width;

        public GeometricFigure(float height, float width) {
            this.height = height;
            this.width = width;
        }

        public float getHeight() { return height; }
        public float getWidth() { return width; }

        public void setHeight(float height) { this.height = height; }

        public void setWidth(float width) { this.width = width; }

        public abstract float computeArea();

        




    }
}
