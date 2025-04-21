using System;

namespace AnimeAPP
{
    internal class OnePiece
    {
        // Static field to keep track of the number of instances created
        public static int noOfInstances;

        // Private field to store the captain's name
        private string _captain;

        // Public auto-implemented property for the swordsman
        public string Swordsman { get; set; }

        // Public property with validation logic for setting the captain
        public string Captain
        {
            get { return _captain; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Captain name cannot be null or empty.");
                }
                else if (value != "Monkey D. Luffy")
                {
                    throw new ArgumentException("Captain must be Monkey D. Luffy.");
                }

                _captain = value;
            }
        }

        // Constructor with captain parameter
        public OnePiece(string captain)
        {
            Captain = captain;

            Console.WriteLine("One Piece is a Japanese manga series written and illustrated by Eiichiro Oda.");
            Console.WriteLine($"The captain of the Straw Hat Pirates is {captain}.");

            listArcs();     // Call to static method
            finalArc();     // Call to private static method
            noOfInstances++; // Increment instance count
        }

        // Constructor with both captain and swordsman
        public OnePiece(string captain, string swordsman)
        {
            Captain = captain;
            Swordsman = swordsman;

            Console.WriteLine("One Piece is a Japanese manga series written and illustrated by Eiichiro Oda.");
            Console.WriteLine($"The captain of the Straw Hat Pirates is {captain} and the swordsman is {swordsman}.");
        }

        // Instance method to list crew members
        public void listCrewMembers()
        {
            Console.WriteLine("The Straw Hat Pirates crew members are:");
            Console.WriteLine("1. Monkey D. Luffy (Captain)");
            Console.WriteLine("2. Roronoa Zoro (Swordsman)");
            Console.WriteLine("3. Nami (Navigator)");
            Console.WriteLine("4. Usopp (Sniper)");
            Console.WriteLine("5. Sanji (Cook)");
            Console.WriteLine("6. Tony Tony Chopper (Doctor)");
            Console.WriteLine("7. Nico Robin (Archaeologist)");
            Console.WriteLine("8. Franky (Shipwright)");
            Console.WriteLine("9. Brook (Musician)");
        }

        // Instance method to simulate a fight
        public void fight()
        {
            Console.WriteLine($"{Captain} and {Swordsman} are fighting against the Marines.");
        }

        // Static method to list One Piece story arcs
        public static void listArcs()
        {
            Console.WriteLine("The One Piece arcs are:");
            Console.WriteLine("1. East Blue Saga");
            Console.WriteLine("2. Alabasta Saga");
            Console.WriteLine("3. Skypiea Saga");
            Console.WriteLine("4. Water 7 Saga");
            Console.WriteLine("5. Thriller Bark Saga");
            Console.WriteLine("6. Summit War Saga");
        }

        // Private static method to describe the final arc
        private static void finalArc()
        {
            Console.WriteLine("The final arc of One Piece is the Wano Country Arc.");
            Console.WriteLine("The Wano Country Arc is set in a land inspired by feudal Japan.");
            Console.WriteLine("It follows the Straw Hat Pirates as they ally with the samurai of Wano to overthrow the tyrannical rule of Kaido and Orochi.");
        }
    }
}
