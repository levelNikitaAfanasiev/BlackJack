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
                Write.WriteLine($"Croupier {count}");
                return true; 
            }
            }while(count <= 17);
            Write.WriteLine($"Croupier {count}");
            return false;
        }
    }
    
}
