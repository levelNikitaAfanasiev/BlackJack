using System;

namespace blackjack
{
   class Сroupier{
        public int count;
        public Сroupier(){
            count+=Cards.Turn();
        }
        public bool Play(){
             do{
                  count+=Cards.Turn();
                   if(count > 21)
             {
                 Console.WriteLine("Croupier {0}", count);
                 return true; 
             }
             }while(count <= 17);
              Console.WriteLine("Croupier {0}", count);
             return false;
        }
    }
    
}
