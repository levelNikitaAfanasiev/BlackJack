using System;
using System.Collections.Generic;

namespace blackjack
{
   class Card{
         public string Name {get;set;}  
        public string Lear {get;set;}
        public int Value {get;set;}
        public Card(string name,string lear, int value){
          Name = name;
          Lear = lear;
          if(name == "J" || name == "ten" || name == "Q" || name == "K")
          {
            Value = 10;
          }
          else
          {
          Value = value;
          }
        }
       
    }
}
    

