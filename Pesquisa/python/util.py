import random
import time
from pesquisa import Pesquisa

class Util:
    def popularVetor(qtdValores):
        i = 0
        lista = []
        while(i < qtdValores):
            lista.append(random.randint(-9999999, 9999999))
            i = i+1

        return lista

    def init():
        lista = []
        qtd = int(input("Quantos valores deseja? "))
        lista = Util.popularVetor(qtd)
        # exibir(lista)
        lista.sort()
        # exibir(lista)
        pesquisa = int(input("Qual valor deseja procurar"))
        Util.pesquisas(lista, pesquisa)


    def pesquisas(lista, pesquisa):
        tempoInicio = time.time()
        Pesquisa.pesquisaSequencial(lista, pesquisa)
        tempoFim = time.time()
        print("Tempo de pesquisa sequencial: ", (tempoFim - tempoInicio) , "s")

        tempoInicio = time.time()
        Pesquisa.pesquisaBinaria(lista, pesquisa)
        tempoFim = time.time()
        print("Tempo de pesquisa binaria: ", (tempoFim - tempoInicio) , "s")
        

        tempoInicio = time.time()
        for pesquisa in lista:
            pass
        tempoFim = time.time()
        print("Tempo de pesquisa do python: ", (tempoFim - tempoInicio) , "s")
