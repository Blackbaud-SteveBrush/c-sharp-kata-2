# C# Kata 2: Arrays & Sorting

1. Create a new `dotnet` application.
2. Open **Program.cs** and change the file’s namespace to `Kata2`.
3. Create a new file named **Player.cs**, which should contain a `public` class that takes a `firstName`, a `lastName`, and an `int` `level` in the constructor.
4. Set the first and last name to `private` class properties; set the `level` to a `public` class property.
5. Create a `private` method that returns the first and last name, and the player’s level, as a single string.
6. Create a new file named **Leaderboard.cs**, which should contain a public class with a method to add players to an array.
7. Create a public method within `Leaderboard` named `PrintStats()`. This method should print all players’ names and levels to the console. The output should be ordered by the players’ level property, showing the player with the highest level at the top of the board.
8. In the **Program.cs** main method, implement the `Leaderboard` class, add a few instances of `Player`, and print the player’s stats to the console.
