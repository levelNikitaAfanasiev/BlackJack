using System;

namespace blackjack
{
   class Player{
       
        public byte count;
          public Player(){
              count+=Cards.Turn();
                         
       }
       public bool Play()
       {
           ConsoleKeyInfo check;
           do{
             count+=Cards.Turn();
             Console.WriteLine("Your Cards {0}", count);     
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
