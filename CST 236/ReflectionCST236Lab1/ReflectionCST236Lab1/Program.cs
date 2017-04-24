using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;

namespace ReflectionCST236Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           Class1 test = new Class1();
           Type t = test.GetType();
           Console.WriteLine("Type Name: " + t.Name + Environment.NewLine);
           Console.WriteLine("Namespace: " + t.Namespace + Environment.NewLine);
           Console.WriteLine("BaseType: " + t.BaseType + Environment.NewLine);


        //private data members
           Console.WriteLine(Environment.NewLine + "Private data Members:");
            FieldInfo[] fields = t.GetFields(
                         BindingFlags.NonPublic | 
                         BindingFlags.Instance);

            foreach (var privateMembers in fields)
            {
                Console.WriteLine(privateMembers.ToString());
            }

        
            //get public methods
            Console.WriteLine(Environment.NewLine+"Public Method Signatures:");
            MethodInfo[] myArrayMethodInfo = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var publicMethod in myArrayMethodInfo)
            {
               Console.WriteLine(publicMethod.ToString());
            }
        }
    }
}
