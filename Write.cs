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
          file.WriteAsync(array1);
          file.WriteAsync(array2);
      }
     
       
    }
}
    

