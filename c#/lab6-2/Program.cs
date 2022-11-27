using System;
using System.Collections;


namespace Lab1 {
    public interface IFigure {
        public float square();
    }
    public class Circle : IFigure {
        private float r;
        private string color;
        public float square() {
            return (r * r * 3.14f);
        }
        public Circle(double r, string c) {
            this.r = (float)r;
            this.color = c;
        }
    }
    public class Square : IFigure {
        private float a;
        public Square(double a) {
            this.a = (float)a;
        }
        public float perim {
            get { return (4 * a); }
        }
        public float square() {
            return (a * a);
        }
    }
    public class Shapes : IEnumerable {
        private IFigure[] shapes=new IFigure[20];
        private int length=0;
        public IEnumerator GetEnumerator() {
            return shapes.GetEnumerator();
        }
        public void add(IFigure o) {
            this.shapes[length++] = o;
        }
    }
    public class Program {
        static void Main() {
            Shapes s1 = new Shapes();
            Circle a1 = new Circle(1,"a");
            Circle a2 = new Circle(2.3,"b");
            Square b1 = new Square(1.2);
            Square b2 = new Square(2.1);
            s1.add(a1);
            s1.add(a2);
            s1.add(b1);
            s1.add(b2);
            foreach (IFigure z in s1)
                if (z != null)
                    Console.WriteLine(z.square());
        }
    }
}