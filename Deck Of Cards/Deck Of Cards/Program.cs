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

      game1.Start();

      Console.ReadKey();
    }
  }

  class Deck
  {

    private int[,] arr = new int[4, 8];
    private string[] suit = new string[4] { "Diamonds", "Hearts", "Spades", "Clubs" };
    private string[] cards = new string[8] { "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

    public void SetDeck()
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

          if (arr[r, c] == 0)
          {

            arr[r, c] = i;

            break;
          }
        }

      }


    }

    public void ShowDeck()
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

    public void Handing(ref int n, ref int sum1, ref int sum2, ref string str1, ref string str2)
    {
      while (n <= 4)
      {
        for (int i = 0; i < 4; i++)
        {
          for (int j = 0; j < 8; j++)
          {
            if (arr[i, j] == n)
            {
              if (n % 2 != 0)
              {
                str1 += $" *{cards[j]} of {suit[i]}*";
                int b = 0;
                switch (cards[j])
                {
                  case "Seven":
                    b = 7;
                    break;
                  case "Eight":
                    b = 8;
                    break;
                  case "Nine":
                    b = 9;
                    break;
                  case "Ten":
                  case "Jack":
                  case "Queen":
                  case "King":
                    b = 10;
                    break;
                  case "Ace":
                    b = 11;
                    break;
                }
                sum1 += b;
              }
              else {

                str2 += $" *{cards[j]} of {suit[i]}*";
                int b = 0;
                switch (cards[j])
                {
                  case "Seven":
                    b = 7;
                    break;
                  case "Eight":
                    b = 8;
                    break;
                  case "Nine":
                    b = 9;
                    break;
                  case "Ten":
                  case "Jack":
                  case "Queen":
                  case "King":
                    b = 10;
                    break;
                  case "Ace":
                    b = 11;
                    break;
                }
                sum2 += b;

              }
            }
          }
        }
        n++;
      }
      Console.WriteLine($"The Player has: {str1} (sum is: {sum1})\n");
      Console.WriteLine($"The Computer has: {str2} (sum is: {sum2})\n");

    }

    public void HandingOne(ref int n, ref int sum1, ref int sum2, ref string str1, ref string str2)
        {
            int k = n + 1;

            while (n <= k)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (arr[i, j] == n)
                        {
                            if (n % 2 != 0)
                            {
                                str1 += $" *{cards[j]} of {suit[i]}*";
                                int b = 0;
                                switch (cards[j])
                                {
                                    case "Seven":
                                        b = 7;
                                        break;
                                    case "Eight":
                                        b = 8;
                                        break;
                                    case "Nine":
                                        b = 9;
                                        break;
                                    case "Ten":
                                    case "Jack":
                                    case "Queen":
                                    case "King":
                                        b = 10;
                                        break;
                                    case "Ace":
                                        b = 11;
                                        break;
                                }
                                sum1 += b;
                            }
                            else
                            {

                                str2 += $" *{cards[j]} of {suit[i]}*";
                                int b = 0;
                                switch (cards[j])
                                {
                                    case "Seven":
                                        b = 7;
                                        break;
                                    case "Eight":
                                        b = 8;
                                        break;
                                    case "Nine":
                                        b = 9;
                                        break;
                                    case "Ten":
                                    case "Jack":
                                    case "Queen":
                                    case "King":
                                        b = 10;
                                        break;
                                    case "Ace":
                                        b = 11;
                                        break;
                                }
                                sum2 += b;

                            }
                        }
                    }
                }
                n++;
            }
            Console.WriteLine($"\nThe Player has: {str1}\n(sum is: {sum1})\n\n");
            Console.WriteLine($"The Computer has: {str2}\n(sum is: {sum2})\n");

        }

    }


  class Game
  {
    public Game()
    {
      deck = new Deck();
      deck.SetDeck();
      n = 1;
    }

    private int n;
    public void ShowDeck()
    {
      deck.ShowDeck();

    }

    public bool check (int sumPlayer, int sumComp)
    {
      if (sumPlayer == sumComp && sumComp == 21)
      {
        Console.WriteLine("Draw, Start new game!!!");
        return false;
      }

      if (sumPlayer == 21)
      {
        Console.WriteLine("Player You win, Congratulations!!!");
        return false;
      }

      if (sumComp == 21)
      {
        Console.WriteLine("Computer win, you lose!!! Try again...");
        return false;
      }
      return true;
    }


    private Deck deck;

    public void Start()
    {
      n = 1;
      deck.SetDeck();
      string cardsPlayer = string.Empty;
      string cardsComp = string.Empty;

      int sumPlayer = 0;
      int sumComp = 0;
      char key;
      bool flag = true;

      while (flag)
      {
        Console.WriteLine( "*****Welcome to Blackjack*****" );
        Console.WriteLine("\nWe Start Our Game!!!\n");
        Console.WriteLine(new string('-', 80));
        Console.WriteLine();
        deck.Handing(ref n, ref sumPlayer, ref sumComp, ref cardsPlayer, ref cardsComp); // Start game Handing two cards for each player

        flag = check(sumPlayer, sumComp); // Checking if any player wins
        if (flag == false)
          break;
                
                do
                {
                    Console.WriteLine("Do You want any card or check ? (y/n)");
                    key = Convert.ToChar(Console.ReadLine());
                    if (key == 'y')
                    {

                        deck.HandingOne(ref n, ref sumPlayer, ref sumComp, ref cardsPlayer, ref cardsComp);
                        check(sumPlayer, sumComp);
                        if (sumPlayer > 21 && sumComp < 21)
                            Console.WriteLine("You lose!!!");
                        if (sumComp > 21 && sumPlayer < 21)
                            Console.WriteLine("You win!!!");
                        if (sumComp > 21 && sumPlayer > 21)
                            Console.WriteLine("Draw, try again");
                        

                    }
                    else
                    {
                        flag = false;
                        if(sumPlayer > sumComp)
                           Console.WriteLine("You Win!!!");
                        else if (sumComp > sumPlayer)
                            Console.WriteLine("You lose!!!");
                        else Console.WriteLine("Draw, try again");
                        Console.WriteLine("Good Luck!!!");
                        break;
                    }

                }
                while (sumPlayer < 21 && sumComp < 21);

                flag = false;



            }


    }

  }

}
