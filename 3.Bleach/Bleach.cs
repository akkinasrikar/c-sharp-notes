using System;

namespace BleachApp
{
    // Represents a character from the Bleach anime series
    internal class Bleach
    {
        // Static field to generate a unique ID for every character
        private static int nextID = 0;

        // Readonly field to store the unique ID of each character instance
        private readonly int id;

        // Public property for character name
        public string Name { get; set; }

        // Readonly description generated in the constructor
        public string Description { get; }

        // Private backing field for the write-only Bankai property
        private string _bankai;

        // Write-only property: Bankai (cannot be read outside)
        public string Bankai
        {
            set { _bankai = value; }
        }

        // Constant field: Shared across all instances, cannot be changed
        public const string Villan = "Yhwach";

        // Readonly field: Can be assigned in constructor, accessed via instance
        public readonly string Hero;

        // Constructor to initialize Bleach character with name
        public Bleach(string Name)
        {
            id = nextID++; // Assign a unique ID
            this.Name = Name; // Assign passed name to instance property

            // Auto-generate description
            Description = $"This is a character {Name} from the Bleach series.";

            // Assign Bankai and Hero values based on character
            if (Name == "Ichigo Kurosaki")
            {
                Bankai = "Tensa Zangetsu";
                Hero = "Ichigo Kurosaki"; // Assign Hero only for Ichigo
            }
            else if (Name == "Rukia Kuchiki")
            {
                Bankai = "Hakka no Togame";
            }
            else
            {
                Bankai = "Unknown";
            }

            // Villan = "Yhwach"; ❌ Would throw compile error if attempted here
        }

        // Displays character information to the console
        public void DisplayInfo()
        {
            Console.WriteLine($"Bleach ID: {id}, Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Bankai: {_bankai}"); // Access via private field
            // Console.WriteLine($"Bankai: {Bankai}"); ❌ Would cause compile-time error (no getter)
        }
    }
}
