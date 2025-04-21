namespace AnimeAPP
{
    internal class Anime
    {
      static void Main(string[] args)
      {
        OnePiece onePiece = new OnePiece("Monkey D. Luffy");
        // Console.WriteLine("Welcome to the world of One Piece! & Meet our captain "+ onePiece.Captain);
        //  OnePiece onePiece2 = new OnePiece("Roronoa Zoro");
        OnePiece onePiece3 = new OnePiece("Monkey D. Luffy", "Roronoa Zoro");
        // Console.WriteLine("Welcome to the world of One Piece! & Meet our captain "+ onePiece3.Captain + " and our swordsman " + onePiece3.Swordsman);
        onePiece3.listCrewMembers();
        onePiece3.fight();
      }
    }
}