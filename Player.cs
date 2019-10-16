using System;

namespace blackjack
{
   class Player{
       
    public int count;
  public Player(){
    
    count+=Cards.Turn();
    Console.WriteLine("Card {0} {1}", Cards.card.Name, Cards.card.Lear);
    }
    public bool Play()
     {
      ConsoleKeyInfo check;
      do{
      count+=Cards.Turn();
      Console.WriteLine("Card {0} {1}", Cards.card.Name, Cards.card.Lear);   
      Console.WriteLine("Value {0}", count);   
      if(count > 21)
      {
      return true; 
      }
      Console.WriteLine("Press eny button to take a card");
      Console.WriteLine("Press ESC to take end");
      check = Console.ReadKey();
            
      }while(check.Key != ConsoleKey.Escape);
      return false;
    }
     
  }
    
}
