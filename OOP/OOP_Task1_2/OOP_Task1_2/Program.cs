using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintClassInfo(typeof(Animal));
            PrintClassInfo(typeof(AnimalWithTail));
            PrintClassInfo(typeof(Cat));
            PrintClassInfo(typeof(Dog));
            Console.WriteLine(new Cat("Balck", 2, 1));
            Console.WriteLine(new Dog("Brown", 5, 2));
            Console.ReadLine();
        }
        private static void PrintClassInfo(Type type)
        {
            var props = type.GetProperties();
            var fields = type.GetFields().Concat(type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)).ToArray();
            var constructors = type.GetConstructors();
            var methods = type.GetMethods();

            var sortLambda =
                new Func<MemberInfo, MemberInfo, int>(
                    (first, second) =>
                            String.Compare(first.Name, second.Name, StringComparison.Ordinal));
            Array.Sort(props, sortLambda.Invoke);
            Array.Sort(fields, sortLambda.Invoke);
            Array.Sort(constructors, sortLambda.Invoke);
            Array.Sort(methods, sortLambda.Invoke);
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(
                    $"{propertyInfo.Name}, {propertyInfo.PropertyType}, {propertyInfo.CanRead}, {propertyInfo.CanWrite}");
            }
            foreach (var fieldInfo in fields)
            {
                Console.WriteLine(
                    $"{fieldInfo.Name}, {fieldInfo.FieldType}, {fieldInfo.IsPrivate}, {fieldInfo.IsPublic}, {fieldInfo.IsStatic}, {fieldInfo.IsInitOnly}, {fieldInfo.IsLiteral}");
            }
            foreach (var constructorInfo in constructors)
            {
                Console.WriteLine(
                    $"{constructorInfo.Name}, {constructorInfo.DeclaringType}, {constructorInfo.IsPublic}, {string.Join(", ", constructorInfo.GetParameters().ToArray<object>())}");
            }
            foreach (var methodInfo in methods)
            {
                Console.WriteLine(
                    $"{methodInfo.Name}, {methodInfo.DeclaringType}, {methodInfo.IsPublic}, {string.Join(", ", methodInfo.GetParameters().ToArray<object>())}");
            }
        }
    }
}
