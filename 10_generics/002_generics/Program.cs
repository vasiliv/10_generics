using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_generics
{
    // fields, constructors, properties and printing

    class MyClass<U, V>
    {
        private U field1;
        private V field2;

        public U Field1 { get { return field1; } set { field1 = value; } }
        public V Field2 { get { return field2; } set { field2 = value; } }

        public MyClass(U field1, V field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, int> myClass = new MyClass<int, int>(1,2);
            Console.WriteLine(myClass.Field1 + myClass.Field2);

            MyClass<int, string> myClass1 = new MyClass<int, string>(10, " Comandments");
            Console.WriteLine(myClass1.Field1 + myClass1.Field2);

            Console.ReadLine();
        }
    }
}
