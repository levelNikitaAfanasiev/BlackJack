using System;
using System.Collections.Generic;

namespace blackjack
{
   class Card{
         public string Name {get;private set;}  
        public string Lear {get;private set;}
        public int Value {get;set;}
        public Card(string name,string lear, int value){
          Name = name;
          Lear = lear;
          Value = value;
        }
       
    }
}
    

