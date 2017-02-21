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
            Deck deck1 = new Deck();

            deck1.ShowDeck();

            Console.ReadKey();
        }
    }

    class Deck
    {

        public int [,] arr = new int[4, 8];

        public void SetDeck ()
        {
            Random rand = new Random(DateTime.Now.Second);
            int r, c;
            for (int i = 1; i <= 32; i++)
            {
                do
                {
                    r = rand.Next(1, 4);
                    c = rand.Next(1, 8);
                }

                while (arr[r,c] != 0);

                arr[r, c] = i;
            }
            

        }

        public void ShowDeck ()
        {
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 8; j++)
                    Console.Write(arr[i, j] + "");

                Console.WriteLine();
            }


        }



    }


}
