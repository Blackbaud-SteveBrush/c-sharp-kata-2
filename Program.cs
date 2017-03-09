namespace Kata2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leaderboard = new Leaderboard();
            leaderboard.AddPlayer(new Player("Brandon", "Jones", 5));
            leaderboard.AddPlayer(new Player("Brandon", "Hare", 3));
            leaderboard.AddPlayer(new Player("Lindsey", "Rix", 6));
            leaderboard.AddPlayer(new Player("John", "Lyons", 1));
            leaderboard.PrintStats();
        }
    }
}
