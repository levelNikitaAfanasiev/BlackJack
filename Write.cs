using System;
using System.Collections.Generic;

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
       
    }
}
    

