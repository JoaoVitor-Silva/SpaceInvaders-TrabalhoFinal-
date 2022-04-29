using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class Enemy
    {
        public List<Projetil> ListaProjetilEnemy = new List<Projetil>();
        public float Vel = 0.008f;
        public int X, Y;
        float V = 0f;
        public int Vida = 3;
        int AtackSpeed;


        public Enemy()
        {
            Vel = (float)new Random().NextDouble() * 0.02f;
            X = new Random().Next(0, Program.SizeX);
            AtackSpeed = new Random().Next(1000, 3000);
            Y = 0;
            Vida = 5;
        }

        public bool TakeDamage()
        {
            Vida--;

            if (Vida <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Randomize()
        {
            Vel = 0.008f;
            Y = 0;
            V = 0;
            X = new Random().Next(0, Program.SizeX);
        }

        public void Move()
        {
            V += Vel;
            Y = (int)V;
            if (Y > Program.SizeY)
            {
                Randomize();
            }
        }

        public void Bullet(int timer)
        {
            if (timer >1500)
            {
                if (timer % AtackSpeed <= 20)
                    ListaProjetilEnemy.Add(new Projetil(X, Y + 1, this));
            }

        }
    }
}
