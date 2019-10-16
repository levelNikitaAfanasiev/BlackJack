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
                Console.WriteLine("Winner Croupier");
                lose++;
                return;
            }
            if(croupier.Play()){
                Console.WriteLine("Winner Player");
                wins++;
                return;
            }
            if(player.count > croupier.count )
            {
                Console.WriteLine("Winner Player");
                wins++;
            }
            else if(player.count < croupier.count)
            {
                Console.WriteLine("Winner Croupier");
                lose++;
            }
            else
            {
                Console.WriteLine("No Winner");
             
            }
        }
        public void Gaming()
        {
        ConsoleKeyInfo check;
          
          do{
            
          StartGame();
          Console.WriteLine("wins {0}", wins);
          Console.WriteLine("Loses {0}", lose);
          Console.WriteLine("Press eny button to play again");
          Console.WriteLine("Press ESC to take end this game");
          check = Console.ReadKey();
          Console.Clear();
          }while(check.Key != ConsoleKey.Escape);
        }

    }
    
}
