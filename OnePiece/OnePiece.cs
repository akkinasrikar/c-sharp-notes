using System;

namespace AnimeAPP
{
    internal class OnePiece
    {
        private string _captain;
        public string Swordsman { get; set; }
        public string Captain 
        {
            get { return _captain; }
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("captain name cannot be null or empty.");
                } else if (value != "Monkey D. Luffy")
                {
                    throw new ArgumentException("Captain must be Monkey D. Luffy.");
                }
                _captain = value; 
            }
        }
        public OnePiece(string captain)
        {
            Captain = captain;
            Console.WriteLine("One Piece is a Japanese manga series written and illustrated by Eiichiro Oda.");
            Console.WriteLine($"The captain of the Straw Hat Pirates is {captain}.");

        }

        public OnePiece(string captain, string swordsman)
        {
            Captain = captain;
            Swordsman = swordsman;
            Console.WriteLine("One Piece is a Japanese manga series written and illustrated by Eiichiro Oda.");
            Console.WriteLine($"The captain of the Straw Hat Pirates is {captain} and the swordsman is {swordsman}.");
        }

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

        public void fight()
        {
            Console.WriteLine($"{Captain} and {Swordsman} are fighting against the Marines.");
        }
    }
}