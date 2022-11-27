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
        private float[,] m1 = { { 1, 2.3f, 4.6f },{ 2,6,9.4f} };
        public float this[int ind1, int ind2] {
            get { return m1[ind1, ind2]; }
        }
        private float[] m;
        public float this[int ind1] {
            get { return m[ind1]; }
        }
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
        public int mlen {
            get { return m.Length; }
        }

    }
    public class C<p> {
        public static int I = 10;
        public p[] h = new p[3];
        public p this[int ind1] {
            get { return h[ind1]; }
            set { h[ind1] = value; }
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
            Console.WriteLine("Values from m:");
            for (int i = 0; i < b1.mlen; i++) {
                Console.WriteLine(b1[i]);
            }
            Console.WriteLine("Values from m1:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine(b1[i, j]);
                }
            C<int> c1 = new C<int>();
            C<string> c2 = new C<string>();
            for (int i = 0; i < 3; i++) {
                c1[i] = i * C<int>.I;
            }
            for (int i = 0; i < 3; i++) {
                c2[i] = i.ToString();
            }
            Console.WriteLine("Values from c1.h:");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(c1[i]);
            }
            Console.WriteLine("Values from c2.h:");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(c2[i]);
            }
        }
    }
}