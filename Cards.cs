using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    
   class Cards{
       public static Card card = new Card("","", 0);
       List<string> Lear = new List<string>(){
           "CH",
           "CR",
           "PE",
           "BU"
       };
       Dictionary<string,int> Name = new Dictionary<string,int>(){
          {"2",2},
            {"3",3},
            {"4",4},
            {"5",5},
            {"6",6},
            {"7",7},
            {"8",8},
            {"9",9},
            {"10",10},
            {"J",10},
            {"Q",10},
            {"K",10},
            {"T",11}
       };
        public static List<Card> deck = new List<Card>();
        Random rand = new Random();
        public Cards(){            
              foreach (var item in Name)
              { 
               foreach (var b in Lear)
                {      
                  deck.Add(new Card(item.Key,b,item.Value));
                }
              }                      
        }  
        
        public void Shuffer()
        {    
          deck  = deck.OrderBy(v => rand.Next()).ToList();  
        }
      public static int Turn()
      {
          
        int cardValue = 0;
        var list = deck.LastOrDefault();
      
        card.Name = list.Name;
        card.Lear = list.Lear;
        cardValue = list.Value;
        deck.RemoveAt(deck.Count-1);
        
        return cardValue;
      }
    } 
}
