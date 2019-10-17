using System;
using System.IO;


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
                Write.WinCroupier();
                lose++;
                return;
            }
            if(croupier.Play()){
                Write.WinPlayer();
                wins++;
                return;
            }
            if(player.count > croupier.count )
            {
                Write.WinPlayer();
                wins++;
            }
            else if(player.count < croupier.count)
            {
                Write.WinCroupier();
                lose++;
            }
            else
            {
                Write.NoWinner();
             
            }
        }
        public void Gaming()
        {
          ConsoleKeyInfo check;
          string Path = "/home/dev/Desktop/blackjack/Games";
          do{
                using(FileStream file = new FileStream(Path,FileMode.Open))
                {
                    StartGame();               
                    check = Write.WinsAndLoses(lose, wins);
                    Write.WriteInFile(file,wins,lose);
                 }
            }while(check.Key != ConsoleKey.Escape);
                
          
        }

    }
    
}
