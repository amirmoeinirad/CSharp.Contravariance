
// Amir Moeini Rad
// August 20, 2025
// Help from Google NotebookLM

// Main Concept: Contravariance in Delegates
// Contravariance means that a delegate expecting a more specific type can wrap/encapsulate a method accepting a more general type.
// For example, a delegate that takes an object can also take a string or an int, since both are derived from object.
// Therefore, the specific types must be subtypes of the general type (superclass).
// "Contra-": against, opposite + "Variance": change, variation.


namespace Contravariance
{
    public class ContravarianceExample
    {
        // A method that takes an object and logs its type and value.
        static void LogObject(object item)
        {
            Console.WriteLine($"Logging object: {item.GetType().Name} - {item}");
        }



        // The Main method to demonstrate contravariance with delegates.
        public static void Main()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Contravariance for Parameter Types with Delegates in C#.NET.");
            Console.WriteLine("------------------------------------------------------------\n");


            // 1. Create an Action<object> delegate instance
            // This delegate can accept any object.
            // 'System.Action<in T>(T obj)' is a built-in generic delegate type in .NET that represents a method that takes a parameter and returns void.
            // The 'objectLogger' instance points to the 'LogObject' method.
            Action<object> objectLogger = LogObject;



            // 2. Demonstrate contravariance.
            // Assign the Action<object> to an Action<string>.
            // This is valid because Action<object> can handle a string (which is an object).
            // The delegate is 'contravariant in T' for Action<T>.
            Action<string> stringLogger = objectLogger;            



            // 3. Invoke the Action<string> with a string.
            // The underlying LogObject method, which expects an object, successfully processes the string.
            stringLogger("Hello Contravariance!\n");

            // You can also directly invoke the objectLogger with a string for comparison.
            objectLogger("Another string as an object.\n");

            // And with an int, which is boxed to an object.
            objectLogger(123);



            Console.WriteLine("\nDone.");
        }
    }
}
