using System.Collections.Generic;

namespace blackjack21
{
    class Player
    {
        public string Name {get; set;}
        public List<Card> Cards {get; set;} 


        public int CalculatePoints(){
          int points = 0;
          int aces = 0;

          foreach(Card c in Cards){
             if ( c.Value == "A"){
                 aces++;
                // points++;
             }else if (c .Value == "J" || c.Value == "Q" || c.Value == "K") points += 10;
             else points += int.Parse(c.Value);
          }

          if((points - 21) <= 10 ){
               for(int j=0; j < aces; j++){
                  if(j == 0) points += 11; // Adding at least one 11
                  else points += 1;  // the rest can only be 1s
               }
          }else {
              points += aces; //if we do not have a space for an 11 then lets just add 1s
          }

          return points;
        }
    }
}