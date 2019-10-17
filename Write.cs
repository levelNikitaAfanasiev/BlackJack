using System;
using System.IO;

namespace blackjack
{
     static class Write{
      public static void WriteLine(string massage)
      {
        Console.WriteLine(massage);
      }
      public static void WriteToContinue(string mess)
      {
        Write.WriteLine($"Press eny button to {mess}");
        Write.WriteLine("Press ESC to end");
      }
      public static void WriteInFile(FileStream file, int wins, int loses)
      { 
        
          byte[] array1 = System.Text.Encoding.Default.GetBytes($"wins {wins} ");
          byte[] array2 = System.Text.Encoding.Default.GetBytes($"Loses {loses} ");
          file.Write(array1);
          file.Write(array2);
      }
      public static void WinPlayer()
      {
        Write.WriteLine("Winner Player");
      }
      public static void WinCroupier()
      {
        Write.WriteLine("Winner Croupier");
      }
      public static void NoWinner()
      {
        Write.WriteLine("No Winner");
      }
      public static ConsoleKeyInfo WinsAndLoses(int lose, int win)
      {
        Console.WriteLine($"wins {win}");
        Console.WriteLine($"Loses {lose}");
        Write.WriteToContinue("play again");
        ConsoleKeyInfo check = Console.ReadKey();
        Console.Clear();
        return check;
      }
      public static void PlayerTurn()
      {
         Console.WriteLine("Card {0} {1}", Cards.card.Name, Cards.card.Lear);
      }
      public static void Count(int count, string mess)
      {
        Console.WriteLine($"{mess} value {count}");
      }
     
       
    }
}
    

