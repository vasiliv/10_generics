using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_generics
{
    class MyClass<T>
    {
        public T field;

        public void method()
        {
            Console.WriteLine(field.GetType());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass1 = new MyClass<int>();
            myClass1.method();

            MyClass<string> myClass2 = new MyClass<string>();
            myClass2.field = "sdklfj"; // inicializaciis gareshe exeptions agdebs
            myClass2.method();

            Console.ReadLine();
        }        
    }
}
