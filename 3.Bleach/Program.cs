namespace BleachApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a new instance of the Bleach class with Ichigo
            Bleach ichigo = new Bleach("Ichigo Kurosaki");
            ichigo.DisplayInfo();

            // Create another instance of the Bleach class with Rukia
            Bleach rukia = new Bleach("Rukia Kuchiki");
            rukia.DisplayInfo();

            // Uncommenting the line below will cause a compile-time error because 'Description' is readonly
            // rukia.Description = "This is a character Rukia from the Bleach series.";

            Console.WriteLine(rukia.Description);   // Valid: Description is readonly, not writeable outside constructor

            Console.WriteLine(rukia.Hero); // Will print null since Hero was only assigned for Ichigo
            Console.WriteLine(Bleach.Villan); // Will print "Yhwach" (constant)
        }
    }
}
