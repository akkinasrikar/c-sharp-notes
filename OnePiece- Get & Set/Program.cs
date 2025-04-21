namespace AnimeAPP
{
    internal class Anime
    {
        static void Main(string[] args)
        {
            // Creating an instance using the constructor with only captain
            OnePiece onePiece = new OnePiece("Monkey D. Luffy");

            // Uncomment below to see more interaction outputs
            // Console.WriteLine("Welcome to the world of One Piece! Meet our captain " + onePiece.Captain);

            // Attempt to create an invalid instance (Captain not allowed) - commented for now
            // OnePiece onePiece2 = new OnePiece("Roronoa Zoro");

            // Creating an instance using the constructor with captain and swordsman
            OnePiece onePiece3 = new OnePiece("Monkey D. Luffy", "Roronoa Zoro");

            // Console message with captain and swordsman
            // Console.WriteLine("Welcome to the world of One Piece! Meet our captain " + onePiece3.Captain + 
            //                   " and our swordsman " + onePiece3.Swordsman);

            // Display crew members
            onePiece3.listCrewMembers();

            // Simulate a fight
            onePiece3.fight();

            // List all arcs
            OnePiece.listArcs();

            // Display number of instances created
            Console.WriteLine($"\nTotal number of OnePiece instances created: {OnePiece.noOfInstances}");
        }
    }
}
