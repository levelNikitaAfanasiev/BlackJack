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
      Write.WriteLine($"Card {Cards.card.Name} {Cards.card.Lear}");   
      Console.WriteLine($"Value {count}");   
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
