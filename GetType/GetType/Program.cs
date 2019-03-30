using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GetType
{
    class Program
    {
        static void PrintInterfaces(Type typeSource)
        {
            Console.WriteLine("------ Interfaces ------");

            Type[] interfaces = typeSource.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine("Name:{0}", i.Name);

            Console.WriteLine();
        }

        static void PrintFields(Type typeSource)
        {
            Console.WriteLine("------ Fields ------");

            FieldInfo[] fields = typeSource.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance
                );

            foreach (FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic)
                    accessLevel = "public";
                else if (field.IsPrivate)
                    accessLevel = "private";

                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);
            }

            Console.WriteLine();
        }

        static void PrintMethods(Type typeSource)
        {
            Console.WriteLine("------ Methods ------");

            MethodInfo[] methods = typeSource.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write("Type:{0}, Name:{1}, Parameter:", method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintProperties(Type typeSource)
        {
            Console.WriteLine("------ Properties ------");

            PropertyInfo[] properties = typeSource.GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine("Type:{0}, Name:{1}", property.PropertyType.Name, property.Name);

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);

            Console.ReadKey();
        }
    }
}
