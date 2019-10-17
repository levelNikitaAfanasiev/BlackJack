using System;

namespace blackjack
{
   class Player{
       
    public int count;
  public Player(){
    
    count+=Cards.Turn();
    Write.PlayerTurn();
    }
    public bool Play()
     {
      ConsoleKeyInfo check;
      do{
      count+=Cards.Turn();
      Write.PlayerTurn(); 
      Write.CountPlayer(count);   
      if(count > 21)
      {
      return true; 
      }
      Write.WriteToContinue("take a card");
      check = Console.ReadKey();
            
      }while(check.Key != ConsoleKey.Escape);
      return false;
    }
     
  }
    
}
