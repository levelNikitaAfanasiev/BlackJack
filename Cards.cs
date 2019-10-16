using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    
   class Cards{
        public static Dictionary<string,int> cards = new Dictionary<string,int>()
        {
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
        public static List<KeyValuePair<string,int>> deck = new List<KeyValuePair<string,int>>();
        Random rand = new Random();
        public Cards(){
            for(int i = 0; i < 4; i++){
                foreach(var v in cards)
                {
                    deck.Add(v);
                }
            }
            deck = deck.OrderBy(v => rand.Next()).ToList();         
        }   
      public static int Turn()
      {
        int card = deck.LastOrDefault().Value;
        deck.RemoveAt(deck.Count - 1);
        return card;
      }
    } 
}
