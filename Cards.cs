using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace blackjack
{
    
   class Cards{
       public static Card card;
       enum Lear{
           CH,
           CR,
           PE,
           BU
       };
       enum Name{
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            J = 100,
            Q,
            K,
            T = 11
       };
        public static List<Card> deck = new List<Card>();
        Random rand = new Random();
        public Cards(){           
        foreach (var b in Enum.GetNames(typeof(Lear)))
        {
           foreach (var item in  Enum.GetValues(typeof(Name)))
            {
              deck.Add(new Card(item.ToString(),b,(int)item));
            }
        }      
        }  
        
        public void Shuffer()
        {    
            deck  = deck.OrderBy(v => rand.Next()).ToList();
        }
      public static int Turn()
      {
        card = deck.FirstOrDefault();
        deck.Add(card);
        deck.RemoveAt(0); 
        return card.Value;
      }
    } 
}
