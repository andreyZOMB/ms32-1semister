using System;


namespace Lab1 {


    public class Person : IComparable {
        private string name;
        private int year;
        private string stat;
        public string Name {
            get { return name; }
        }
        public Person() {
            this.name = "no name";
            this.year = 0;
            this.stat = "Безработный";
        }
        public Person(string n, int e, string s) {
            this.name = n;
            this.year = e;
            this.stat = s;
        }
        public int Info {
            get {
                return (Program.nowyear - year);
            }
        }
        public void InfoPrint() {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{Info}");
            Console.WriteLine($"Status:{stat}");
            Console.WriteLine();
        }
        public int CompareTo(object o) {
            Person p = o as Person;
            return this.Info.CompareTo(p.Info);
        }
        public int Compare(Person p1, Person p2) {
            if (String.Compare(p1.Name, p2.Name) > 0)
                return 1;
            else if (String.Compare(p1.Name, p2.Name) < 0)
                return -1;
            else
                return 0;
        }
    }
    public class Student : Person {
        private byte mathMark;
        private byte fizMark;
        private byte histMark;
        public Student(string n, int e, byte m, byte f, byte h) : base(n, e, "Студент") {
            this.fizMark = f;
            this.mathMark = m;
            this.histMark = h;
        }
        public float AveMark {
            get { return ((fizMark + mathMark + histMark) / 3f); }
        }
        new public byte Info {
            get {
                byte rez = fizMark;
                if (rez < mathMark)
                    rez = mathMark;
                if (rez < histMark)
                    rez = histMark;
                return rez;
            }
        }

    }
    interface IComparer<p> {
        int Compare(p o1, p o2);
    }
    class PeopleComparer : IComparer<Person> {
        public int Compare(Person p1, Person p2) {
            if (String.Compare(p1.Name, p2.Name) > 0)
                return 1;
            else if (String.Compare(p1.Name, p2.Name) < 0)
                return -1;
            else
                return 0;
        }
    }





    public class Program {
        public static int nowyear = 2021;
        static void Main() {
            PeopleComparer c1 = new PeopleComparer();
            Person a1 = new Person();
            Person a2 = new Person("Nik", 2010, "Школьник");
            Person a3 = new Person("Katerina", 1990, "Бухгалтер");
            Person a4 = new Person("Liz", 1999, "Студент");
            Student b1 = new Student("Kier", 2001, 8, 7, 9);
            Person[] people = new Person[]{ a1, a2, a3, a4 };
            Console.WriteLine("Сортировка по возрасту");
            Array.Sort(people);
            foreach (Person z in people)
                z.InfoPrint();
            Console.WriteLine("Сортировка по фамилии");
            foreach (Person z in people)
                z.InfoPrint();
        }
    }
}