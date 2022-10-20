namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();
            videoGames.Add("Tank");
            videoGames.Add("SpaceRace");
            videoGames.Add("Space Invaders");
            videoGames.Add("Galaxy");
            videoGames.Add("Pong");
            videoGames.Add("Maze War");
            videoGames.Add("Donkey Kong");
            videoGames.Add("Hunt the Wumpus");
            videoGames.Add("Colossal Cave Adventure");


            foreach (var videoGame in videoGames.OrderBy(s => s.Length))
            {
                Console.WriteLine(videoGame);
            }

        }
    }
}
