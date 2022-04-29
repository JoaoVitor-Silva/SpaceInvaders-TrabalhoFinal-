using System;
using System.Threading;
using System.Collections.Generic;

namespace TrabalhoFinal
{
    static class Program
    {

        public static int SizeX = 30;
        public static int SizeY = 30;
        static char[,] Mapa = new char[SizeX, SizeY];
        

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            int Score = 0;
            int Qenemy = 10;
            int timer = 0;

            Player P = new Player();
            List<Enemy> ListaDeEnemys = new List<Enemy>();
            //Enemy[] ListaDeEnemys = new Enemy[Qenemy];
            Projetil PP = new Projetil();

            for (int i = 0; i < Qenemy; i++)
            {
                ListaDeEnemys.Add(new Enemy());
            }

            Console.WriteLine("Vamos la soldado, vamos destruir esses invasorea!!!!");
            Thread.Sleep(5000);
            Console.Clear();

            while (!Lose(P) && !Win(P))
            {
                Colision(P, ListaDeEnemys);
                foreach (Enemy o in ListaDeEnemys)
                {
                    o.Move();
                    o.Bullet(timer);

                    for (int i = 0; i < o.ListaProjetilEnemy.Count; i++)
                    {
                        o.ListaProjetilEnemy[i].ProjetilEnemy();
                    }
                }
                for (int i = 0; i < P.ListaProjetilPlayer.Count; i++)
                {
                    P.ListaProjetilPlayer[i].ProjetilPlayer();
                }


                P.Input(timer );
                Draw(P, ListaDeEnemys, Score);

                if (timer % 3000 < 20)
                {
                    Qenemy++;
                    ListaDeEnemys.Add(new Enemy());

                }
                timer += 20;
                Thread.Sleep(20);
            }
        }


        static bool Lose(Player p)
        {
            if (p.Vida <= 0 || p.Score < 0)
            {
                
                Console.Beep(400, 500);
                Console.Beep(350, 500);
                Console.Beep(340, 1000);
                Console.Beep(300, 100);
                Console.ReadKey();
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Win(Player p)
        {
            if (p.Score >= 100)
            {
                Console.WriteLine("Você ganhou!!");
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125);
                Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125);
                Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375);
                Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250);
                Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125);
                Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42);
                Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125);
                Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125);
                Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125);
                Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125);
                Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125);
                Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250);
                Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125);
                Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42);
                Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125);
                Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125);
                Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125);
                Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125);
                Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375);
                Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42);
                Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167);
                Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125);
                Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250);
                Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42);
                Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125);
                Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625);
                Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42);
                Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167);
                Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125);
                Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250);
                Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250);
                Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125);
                Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125);
                Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125);
                Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125);
                Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125);
                Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125);
                Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125);
                Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125);
                Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125);
                Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125);
                Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125);
                Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250);
                Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                Console.ReadKey();
                Thread.Sleep(5000);
                return true;

            }
            else
            {
                return false;
            }
        }

        //Função da verficar se os elementos colidiram
        static void Colision(Player p, List<Enemy> a)
        {
            //Se o asteroid e o player estiverem na mesma posição x e y
            foreach (Enemy o in a)
            {
                //Colisão do Player e do Inimigo
                if (p.X == o.X && p.Y == o.Y)
                {
                    o.Randomize();
                    p.TakeDamage();
                    p.Score -= 2;
                    Console.Clear();
                }

                //Colisão do Projetil Player
                foreach (Projetil PP in p.ListaProjetilPlayer)
                {
                    if (PP.X == o.X && PP.Y == o.Y)
                    {
                        o.Randomize();
                        o.TakeDamage();
                        p.Score += 2;
                        Console.Clear();
                    }
                }

                foreach (Projetil EE in o.ListaProjetilEnemy)
                {
                    if (p.X == EE.X && p.Y == EE.Y)
                    {
                        p.TakeDamage();
                        p.Score -= 2;
                        Console.Clear();
                    }
                }
            }

        }
        static void Draw(Player P, List<Enemy> a, int Score)
        {
            //Limpa a tela
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Vidas: {P.Vida} HP");
            Console.Write($"Score: {P.Score}pts\n\n");

            //Percorre toda a matriz mapa

            //Percorre as linhas
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                Console.WriteLine();
                //percorre as colunas
                for (int j = 0; j < Mapa.GetLength(1); j++)
                {
                    //Caso o personagem esteja na posição que estamos verificando
                    //Coloca o caractere do personagem na posição correta
                    if (P.X == j && P.Y == i)
                    {
                        Mapa[i, j] = 'A';
                    }


                    //Senão coloca um espaço vazio
                    else
                    {
                        Mapa[i, j] = ' ';
                    }


                    foreach (Enemy o in a)
                    {
                        if (o.X == j && o.Y == i)
                        {
                            Mapa[i, j] = 'V';
                        }
                        else if (o.X == j && o.Y == i)
                        {
                            Mapa[i, j] = ' ';

                        }
                        for (int k = 0; k < o.ListaProjetilEnemy.Count; k++)
                        {
                            if (o.ListaProjetilEnemy[k].X == j && o.ListaProjetilEnemy[k].Y == i)
                            {
                                Mapa[i, j] = '*';
                            }
                        }
                    }

                    foreach (Projetil PP in P.ListaProjetilPlayer)
                    {
                        if (PP.X == j && PP.Y == i)
                            Mapa[i, j] = '|';

                    }
                    //Imprime o que tem na posição da matriz
                    Console.Write(" " + Mapa[i, j]);
                }
            }
        }
    }
}
