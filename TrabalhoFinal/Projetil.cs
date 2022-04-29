using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class Projetil
    {
        public int X ,Y;
        public int Damage = 3;
        Player P;
        Enemy E;

        public Projetil() { }

        public Projetil(int x, int y,Player pp)
        {
            X = x;
            Y = y;
            P = pp;
        }

        public Projetil(int x, int y, Enemy ee)
        {
            X = x;
            Y = y;
            E = ee;
        }

        public void ProjetilPlayer()
        {
            Y--;
            if (Y < 0)
                P.ListaProjetilPlayer.Remove(this);
        }

        public void ProjetilEnemy()
        {
            Y++;
            if (Y < 0)
                E.ListaProjetilEnemy.Remove(this);
        }
    }
}
