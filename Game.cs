using System;

namespace blackjack
{
    
  class Game{
      public int wins = 0;
      public int lose = 0;
        Player player;
        Сroupier croupier;
       
    
        public void StartGame()
        {
            Cards cards = new Cards();
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

    }
    
}
