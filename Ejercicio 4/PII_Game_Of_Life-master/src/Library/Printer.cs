using System;
using System.Text;
using System.Threading;

namespace game_of_life
{
    public class Printer
    {
        public static void Imprimir(bool[,] gameBoard, int width, int height)
        {
            Console.Clear ();
            StringBuilder s = new StringBuilder ();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (gameBoard[x, y])
                        {
                            s.Append ("|X|");
                        }
                        else
                        {
                            s.Append ("___");
                        }
                    }
                    s.Append ("\n");
                }
                Console.WriteLine(s.ToString());
                Thread.Sleep (300);
            }
        }
    }
