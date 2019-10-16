using System;

namespace blackjack
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
          ConsoleKeyInfo check;
          Game game = new Game();
          do{
            
          game.StartGame();
          Console.WriteLine("wins {0}",game.wins);
          Console.WriteLine("Loses {0}", game.lose);
          Console.WriteLine("Press eny button to play again");
          Console.WriteLine("Press ESC to take end this game");
          check = Console.ReadKey();
          Console.Clear();
          }while(check.Key != ConsoleKey.Escape);
        }
    }
    
}
