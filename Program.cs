using System;
using System.Collections.Generic;

namespace blackjack21
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Dealer = new Player{
                Name =  "Dealer",
                Cards = new List<Card> {
                    new Card{Value= "J", Suit = Suits.Spades},
                    new Card{Value= "9", Suit = Suits.Hearts}
                 }
            };

            Player Billy = new Player{
                Name = "Billy",
                Cards = new List<Card>{
                    new Card{Value="2", Suit = Suits.Spades},
                    new Card{Value="2", Suit = Suits.Diamonds},
                    new Card{Value="2", Suit = Suits.Hearts},
                    new Card{Value="4", Suit = Suits.Diamonds},
                    new Card{Value="5", Suit = Suits.Clubs}
                }
            };

            Player Lemmy = new Player{
                Name = "Lemmy",
                Cards = new List<Card>{
                    new Card{Value="A", Suit = Suits.Spades},
                    new Card{Value="7", Suit = Suits.Hearts},
                    new Card{Value="A", Suit = Suits.Diamonds}
                }
            };

            Player Andrew = new Player{
                Name = "Andrew",
                Cards = new List<Card>{
                    new Card{Value="K", Suit = Suits.Diamonds},
                    new Card{Value="4", Suit = Suits.Spades},
                    new Card{Value="4", Suit = Suits.Clubs}
                }
            };

            Player Carla = new Player{
                Name = "Carla",
                Cards = new List<Card>{
                    new Card{Value="Q", Suit = Suits.Clubs},
                    new Card{Value="6", Suit = Suits.Spades},
                    new Card{Value="9", Suit = Suits.Diamonds}
                }
            };

            Console.WriteLine("Dealer's Points = {0}", Dealer.CalculatePoints());
            Console.WriteLine("==========================");
            
            Console.WriteLine(String.Format("0 - Billy's Points = {0}   | {1}", Billy.CalculatePoints(), WhoWon(Dealer, Billy)));
            Console.WriteLine(String.Format("1 - Lemmy's Points = {0}   | {1}", Lemmy.CalculatePoints(), WhoWon(Dealer, Lemmy)));
            Console.WriteLine(String.Format("2 - Andrew's Points = {0}  | {1}", Andrew.CalculatePoints(), WhoWon(Dealer, Andrew)));
            Console.WriteLine(String.Format("2 - Carla's Points = {0}   | {1}", Carla.CalculatePoints(), WhoWon(Dealer, Carla)));
            
        }


        private static string WhoWon(Player dealer, Player player) {
          if (player.CalculatePoints() > 21) {
              return "Looses";
          }else if (dealer.CalculatePoints() > 21){
              return "Wins";
          }else if (player.Cards.Count ==5){
              return "Wins : Has 5 cards";
          }
          return dealer.CalculatePoints() > player.CalculatePoints() ? "Looses" : "Wins";
        }
    }
}
