using System;

namespace blackjack
{
    
  class Game{
      public int wins = 0;
      public int lose = 0;
        Player player;
        Сroupier croupier;
        Cards cards = new Cards();
    
        private void StartGame()
        {
            cards.Shuffer();
            player = new Player();
            croupier = new Сroupier();
            
            if(player.Play()){
                Write.WriteLine("Winner Croupier");
                lose++;
                return;
            }
            if(croupier.Play()){
                Write.WriteLine("Winner Player");
                wins++;
                return;
            }
            if(player.count > croupier.count )
            {
                Write.WriteLine("Winner Player");
                wins++;
            }
            else if(player.count < croupier.count)
            {
                Write.WriteLine("Winner Croupier");
                lose++;
            }
            else
            {
                Write.WriteLine("No Winner");
             
            }
        }
        public void Gaming()
        {
        ConsoleKeyInfo check;
          
          do{
            
          StartGame();
          Write.WriteLine($"wins {wins}");
          Write.WriteLine($"Loses {lose}");
          Write.WriteToContinue("play again");
          check = Console.ReadKey();
          Console.Clear();
          }while(check.Key != ConsoleKey.Escape);
        }

    }
    
}
