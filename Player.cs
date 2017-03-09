namespace Kata2 
{
  public class Player 
  {
    private string FirstName { get; set; }
    private string LastName { get; set; }
    public int Level { get; set; }
    public Player(string firstName, string lastName, int level) 
    {
      FirstName = firstName;
      LastName = lastName;
      Level = level;
    }
    public string GetDescription() 
    {
      return $"{FirstName} {LastName} - Level {Level}";
    }
  }
}
