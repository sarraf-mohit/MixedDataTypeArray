namespace MixedTypeArray
{
    class Program
    {
        static void Main()
        {
            // Create an array of type object to store mixed datatypes
            object[] mixedArray = { 42, "Hello", 2.06f, 'A', true, 7.14 };

            Console.WriteLine("Elements in the mixed array:");
            foreach (var element in mixedArray) 
            {
                Console.WriteLine($"Type: {element.GetType()}, Value: {element}");
            }
        }
    }
}
