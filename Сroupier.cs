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
                Write.CountCroupier(count);
                return true; 
            }
            }while(count <= 17);
            Write.CountCroupier(count);
            return false;
        }
    }
    
}
