﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Ordenacao
    {
        public static void bolha(List<int> lista)
        {
            int i, tmp;
            bool houveTroca;

            do
            {
                houveTroca = false;
                for (i = 0; i < lista.Count - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
            } while (houveTroca);
        }


        public static void selecao(List<int> lista)
        {
            int i, j, tmp;
            int posMenor;

            for (i = 0; i < lista.Count - 1; i++)
            {
                posMenor = i;
                for (j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[posMenor])
                    {
                        posMenor = j;
                    }
                }

                if (i != posMenor)
                {
                    tmp = lista[i];
                    lista[i] = lista[posMenor];
                    lista[posMenor] = tmp;
                }
            }
        }

        public static void insercao(List<int> lista)
        {
            int i, j;
            int tmp;

            for (i = 1; i < lista.Count; i++)
            {
                tmp = lista[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (tmp < lista[j])
                    {
                        lista[j + 1] = lista[j];
                    }
                    else break;
                }
                lista[j + 1] = tmp;
            }
        }


        public static void pente(List<int> lista) {
            int distancia = lista.Count();
            bool houveTroca = true;

            while (houveTroca && distancia > 1) {
                int i = 0;
                distancia = (int)((float)distancia / 1.3);
                if (distancia < 1) {
                    distancia = 1;
                }
                houveTroca = false;
                do{
                    if (lista[i] > lista[i + distancia]) {
                        houveTroca = true;
                        int tmp = lista[i];
                        lista[i] = lista[i + distancia];
                        lista[i + distancia] = tmp;
                    }
                    i++;

                }while(i < lista.Count() - distancia);
            }
        }
    }
}
