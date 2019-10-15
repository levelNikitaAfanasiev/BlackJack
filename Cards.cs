using System;

namespace blackjack
{
    
   static class Cards{
        public static byte[] cards = new byte[13];
        public static Random rand = new Random();
     
      public static byte Turn()
      {
          byte index;
          do{
           index = (byte)rand.Next(cards.Length); 
          }while(cards[index] >= 4);
               switch(index){
                   case 0:{
                      
                       cards[index]++;
                       return 2;
                     
                   }
                   case 1:{
                       cards[index]++;
                       return 3;
                    
                   }
                   case 2:{
                       cards[index]++;
                       return 4;
                      
                   }
                   case 3:{
                       cards[index]++;
                       return 5;
                    
                   }
                   case 4:{
                       cards[index]++;
                       return 6;
                       
                   }
                   case 5:{
                       cards[index]++;
                       return 7;
                  
                   }
                   case 6:{
                       cards[index]++;
                       return 8;
                       
                   }
                   case 7:{
                       cards[index]++;
                       return 9;
                   
                   }
                   case 8:{
                       cards[index]++;
                       return 10;
                    
                   }
                   case 9:{
                       cards[index]++;
                       return 10;
        
                   }
                   case 10:{
                       cards[index]++;
                       return 10;
               
                   }
                   case 11:{
                       cards[index]++;
                       return 10;
                    
                   }
                   case 12:{
                       cards[index]++;
                       return 11;
                    
                   }
               }
               return 0;
      }
    }
    
}
