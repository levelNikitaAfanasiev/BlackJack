using System;

namespace blackjack
{
    
  class Game{
        Player player;
       public Сroupier croupier;
    
        public Game()
        {
            player = new Player();
            croupier = new Сroupier();
           
        }
        public void StartGame()
        {
            if(player.Play()){
                Console.WriteLine("Winner Croupier");
                return;
            }
            if(croupier.Play()){
                Console.WriteLine("Winner Player");
                return;
            }
            if(player.count > croupier.count )
            {
                Console.WriteLine("Winner Player");
            }
            else if(player.count < croupier.count)
            {
                Console.WriteLine("Winner Croupier");
            }
            else
            {
                Console.WriteLine("No Winner");
             
            }
        }

    }
    
}
