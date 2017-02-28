using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            

      Game game1 = new Game();
      game1.deck.SetDeck();
      game1.deck.ShowDeck();

      Console.ReadKey();
        }
    }

    class Deck
    {

        private int [,] arr = new int[4, 8];
        private string[] suit = new string[4] { "Diamonds", "Hearts", "Spades", "Clubs"};
        private string[] cards = new string[8] { "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        public void SetDeck ()
        {
            arr = new int[4, 8];
            Random rand = new Random(DateTime.Now.Millisecond);
            int r, c;
            for (int i = 1; i <= 32; i++)
            {
                while (true)
                {                   
                    r = rand.Next(0, 4);                   
                    c = rand.Next(0, 8);
                    
                    if(arr[r, c] == 0)
                    {
                       
                        arr[r, c] = i;
                        
                        break;
                    }
                }               
              
            }
            

        }

        public void ShowDeck ()
        {
            int number = 1;
            Console.WriteLine("***The sequence of Cards in the Deck***\n");
            while (number <= 32)
            {
                for (int i = 0; i < 4; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {
                        if (arr[i, j] == number)
                            Console.Write($"Card {number:d2}:   * {cards[j]} of {suit[i]} *");

                    }

                }
        Console.WriteLine();
        number++;
      }

        }
   }


   class Game 
   {
    public Game()
    {
      deck = new Deck();
    }
    public Deck deck;
    
   
   
   }

}
