using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCylinderClassComposition
{
    class Circle
    {
        private double r;
        private string color;

        public Circle()
        {
            r = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            color = "red";
            this.r = r;
        }
        public Circle(double r, string color)
        {
            this.r = r;
            this.color = color;
        }
        public double getAreaCirc()
        {
            return 3.14 * r * r;
        }
        public double getRadius()
        {

            return r;
        }
    }

    class Cylinder
    {
        private Circle kruh;
        private double h;
        //constructor with default color, radius and height
        public Cylinder()
        {
            kruh = new Circle();
            h = 1.0;
        }
        //constructor with default radius, color but given height
        public Cylinder(double h)
        {

            kruh = new Circle();
            this.h = h;
        }

        // constructor with default color, but given radius, height

        public Cylinder(double r, double h)
        {

            this.h = h;
            kruh = new Circle(r);

        }

        //A public method retrieving the height

        public double getHeight()
        {
            return h;
        }

        //A public method for computing the volume of cylinder

        public double getVolume()
        {

            return kruh.getAreaCirc() * h;
        }

        public double getRadius()
        {
            return kruh.getRadius();
        }

        public double getBaseArea()
        {
            return kruh.getAreaCirc();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declare and allocate a new instance of cylinder

            Cylinder c1 = new Cylinder();
            Console.WriteLine("Cylinder: \n"
                + " radius=" + c1.getRadius()
                + " height=" + c1.getHeight()
                + " base area=" + c1.getBaseArea()
                + " volume=" + c1.getVolume());
            //Declare and allocate a new instance of cylinder
            // specifying height, with default color and radius

            Cylinder c2 = new Cylinder(10.0);
            Console.WriteLine("Cylinder: \n"
                + " radius=" + c2.getRadius()
                + " height=" + c2.getHeight()
                + " base area" + c2.getBaseArea()
                + " volume=" + c2.getVolume());

            //Declare and allocate a new instance of cylinder
            // specifying radius and height, with default color

            Cylinder c3 = new Cylinder(2.0, 10.0);
            Console.WriteLine("Cylinder: \n"
                + " radius=" + c3.getRadius()
                + " height=" + c3.getHeight()
                + " base area" + c3.getBaseArea()
                + " volume=" + c3.getVolume());
            Console.ReadLine();
        }
    }
}


