using System.Reflection;

namespace ReflectionIntroduction
{
    /// <summary>
    /// This program demonstrates the use of reflection to explore types, methods, properties, and fields
    /// within the ReflectionIntroLibrary.dll assembly. Make sure to add a project reference to the 
    /// ReflectionIntroLibrary in this console application.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load the assembly from the referenced class library
            Assembly assembly = Assembly.LoadFrom("ReflectionIntroLibrary.dll");

            // Get all types in the assembly
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine($"Type: {type.FullName}");

                // Get methods in the type
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($"    Method: {method.Name}");
                }

                // Get properties in the type
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"    Property: {property.Name}");
                }

                // Get fields in the type
                FieldInfo[] fields = type.GetFields();
                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine($"    Field: {field.Name}");
                }
            }
        }
    }
}