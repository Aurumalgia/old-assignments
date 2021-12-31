using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Task1
{
    class Car
    {
        private string model;
        private int mpg;
        public Car(string model) {
            this.model = model;
            this.mpg = 20;
        }

        public Car(string model, int mpg) {
            this.model = model;
            this.mpg = mpg;
        }

        public string getModel() {
            return model;
        }

        public int getMPG() {
            return mpg;
        }

        public void setModel(string model) {
            this.model = model;
        }

        public void setMPG(int mpg) {
            this.mpg = mpg;
        }

        public static Car operator++ (Car car) {
            car.mpg++;
            return car;
        }

        public static Car operator-- (Car car) {
            if (car.mpg > 0)
                car.mpg--;
            return car;
        }

        


    }
}
