using System;

namespace Lab1 {
    public class A {
        private float a = 2.3f;
        private float b = 4.5f;

        public float c {
            get {
                a *= a;
                return (++a / b);
            }
        }
    }
    public class Program {
        static void Main() {
            A a1 = new A();
            Console.WriteLine(a1.c);
        }
    }
}