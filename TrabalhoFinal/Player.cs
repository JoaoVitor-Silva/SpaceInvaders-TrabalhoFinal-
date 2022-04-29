using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class Player
    {

        public int X, Y;
        public int Score;
        public int Vida;
        public List<Projetil> ListaProjetilPlayer = new List<Projetil>();
        int SpeedAttack = 500;
        int LastBullet = 0;

        public Player()
        {
            X = Program.SizeX / 2;
            Y = Program.SizeY - 1;
            Vida = 20;
        }

        public bool TakeDamage()
        {
            Vida -= 2
                ;

            if (Vida <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Input(int timer)
        {
            ConsoleKeyInfo cki;

            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (X < Program.SizeX - 1)
                        X++;
                }
                else if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (X > 0)
                        X--;
                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    Y--;
                }
                else if (cki.Key == ConsoleKey.DownArrow)
                {
                    Y++;
                }

                else if (cki.Key == ConsoleKey.Spacebar)
                {
                    
                    if (timer - LastBullet >= SpeedAttack)
                    {
                        LastBullet = timer;

                        ListaProjetilPlayer.Add(new Projetil(X, Y + 1, this));
                    }

                }
            }
        }
    }
}
