using System;

namespace Tic_Tak_Toe
{
    class Program
    {
        public static string player = "x"; // initially set player 1 as x.
        public static string[] arr = new string[9];
        public static int counter;
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to tic tak toe!");
            Console.WriteLine("  |  |  ");
            Console.WriteLine("--+--+--");
            Console.WriteLine("  |  |  ");
            Console.WriteLine("--+--+--");
            Console.WriteLine("  |  |  ");

            while (counter < 9)
            {
                int number;
                bool game = true;

                while (game)
                {
                    Console.WriteLine("\n\n" + player + "s' move");
                    if (int.TryParse(Console.ReadLine(), out number) && number <= 10 && arr[number - 1] == null)
                    {
                        if (player == "x")
                        {
                            arr[number - 1] = "x";
                            player = "o";
                        }
                        else if (player == "o")
                        {
                            arr[number - 1] = "o";
                            player = "x";
                        }
                        counter++;// counts untill the table is full
                        break;

                    }
                    else
                        Console.WriteLine("Illegal move! Try again.");

                }

                for (int i = 0; i < 9; i++)// to display the table after each player puts 'o' or 'x'.
                {
                    if ((i==1)||(i==4)||(i==7))
                    {
                        Console.Write("");
                    }
                    Console.Write(arr[i] + "");
                    if (arr[i] == null)
                    {
                        Console.Write("");
                    }
                    if ((i == 2)||(i == 5)||(i == 8))
                    {
                        Console.WriteLine();

                    }
                    if ((i == 2)||( i == 5))
                            {
                    Console.WriteLine("--+---+---");
                }
                if ((i==0)||(i == 1)||(i == 3 )||(i == 4)||(i == 6)||(i == 7))
                        {
                    Console.Write("  |  ");
                }
            }




        }

        Console.WriteLine("Game over!!");

        }



}
}
