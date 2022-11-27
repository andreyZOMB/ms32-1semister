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
                a += a;
                return (++a / b);
            }
        }
    }
    public class B : A {
        private float d;
        private float[] m;
        public float c2 {
            get {
                for (int i = 0; i < 5; i++)
                    d += d;
                return (d / (c * c));
            }
        }
        public B(float x) : base(3.6f, 1.3f) {
            this.d = x;
            m = new float[(int)a1];
            int i = 0;
            foreach (float z in m) {
                m[i] = i * c2;
                i++;
            }

        }
        public float[] m1 {
            get { return m; }
        }

    }
    public class Program {
        static void Main() {
            A a1 = new A(5.7f, 7.8f);
            Console.WriteLine("c = ");
            Console.WriteLine(a1.c);
            B b1 = new B(4.6f);
            Console.WriteLine("c2 = ");
            Console.WriteLine(b1.c2);
            float[] m2 = b1.m1;
            Console.WriteLine("Values from m2:");
            foreach (float i in m2) {
                Console.WriteLine(i);
            }
        }
    }
}