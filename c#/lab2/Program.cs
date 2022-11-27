using System;


namespace Lab1 {
    public class A {
        private float a;
        private float b;
        public float a1 {
            get { return a; }
        }
        public float b1 {
            get { return b; }
        }
        public A(float z, float y) {
            this.a = z;
            this.b = y;
        }

        public float c {
            get {
                a *= a;
                return (++a / b);
            }
        }
    }
    public class B : A {
        private float d;
        public B(float x) : base(3.6f, 1.3f) {
            this.d = x;
        }
        public float c2 {
            get {
                for (int i = 0; i < 3; i++)
                    d *= d;
                return (d / (c * c));
            }
        }

    }
    public class Program {
        static void Main() {
            A a1 = new A(5.7f, 7.8f);
            Console.WriteLine(a1.c);
            B b1 = new B(4.6f);
            Console.WriteLine(b1.c2);
        }
    }
}