namespace Collections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // List of integers
            Predicate<int> isEven = x => x % 2 == 0; // Predicate to check if a number is even
            List<int> evenNumbers = numbers.FindAll(isEven); // Find all even numbers
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            List<Product> products = new List<Product> // List of instances of Product
            {
                new Product("Apple", 1.20m),
                new Product("Banana", 0.80m),
                new Product("Cherry", 2.50m)
            };
            Predicate<Product> isExpensive = p => p.Price > 1.00m; // Predicate to check if a product is expensive
            List<Product> expensiveProducts = products.FindAll(isExpensive); // Find all expensive products
            foreach (Product product in expensiveProducts) 
            {
                Console.WriteLine(product.ToString()); // Print the string representation of each expensive product
            }
            products.Where(p => p.Price > 1.00m).ToList().ForEach(p => Console.WriteLine(p.ToString())); // Using LINQ to filter and print expensive products

            int? age = null; // Nullable integer
            int defaultAge = age ?? 18; // Use null-coalescing operator to provide a default value
            Console.WriteLine($"Default age: {defaultAge}"); // Print the default age
            if (age.HasValue) // Check if age has a value
            {
                Console.WriteLine($"Age: {age.Value}"); // Print the age value
            }
            else
            {
                Console.WriteLine("Age is null"); // Print if age is null
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>(); // Create a dictionary
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, $"Value {i}"); // Add key-value pairs to the dictionary
            }
            foreach (var kvp in dictionary) // Iterate through the dictionary
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); // Print each key-value pair
            }
            dictionary.Add(10, "Value 10"); // Add another key-value pair
            dictionary[0] = "Updated Value 10"; // Update the value for key 10
            foreach (var kvp in dictionary) // Iterate through the dictionary again
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); // Print each key-value pair
            }
            dictionary.Remove(0); // Remove the key-value pair with key 0
            dictionary.AsQueryable().Where(kvp => kvp.Key > 5).ToList().ForEach(kvp => Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")); // Using LINQ to filter and print key-value pairs with key greater than 5
            if(dictionary.TryGetValue(12, out string value)) // Try to get the value for key 10
            {
                Console.WriteLine($"Value for key 12: {value}"); // Print the value if found
            }
            else
            {
                Console.WriteLine("Key 12 not found"); // Print if key 10 is not found
            }
            var codes = new Dictionary<string, string>
            {
                { "A", "Alpha" },
                { "B", "Bravo" },
                { "C", "Charlie" }
            };
            foreach (var kvp in codes)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); // Print each key-value pair
            }
        }
    }

}