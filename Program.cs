using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitVS2017
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();

            Shape t = new Tesseract();
            t.Draw();

            Console.ReadKey();

        }
    }

    class Shape
    {
        // ---virtual---
        //virtual keyword allows methods to be overrided in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Base Draw");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            //draw a circle and stuff...
            Console.WriteLine("Circle Drawn");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            //draw a rectangle and stuff...
            Console.WriteLine("Rectangle Drawn");
        }
    }

    class Tesseract : Shape
    {
        public override void Draw()
        {
            //draw a... thing 
            Console.WriteLine("Ma che cazz...!?!?!");
        }
    }

}

