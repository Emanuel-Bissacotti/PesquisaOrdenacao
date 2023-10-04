#contem os metodos estaticos de ordenacao
class Ordenacao:
    @staticmethod
    def bolha(lista):
        houveTroca = True
        while (houveTroca):
            houveTroca = False
            for i in range(0, len(lista) - 1):
                if (lista[i] > lista[i+1]):
                    houveTroca = True
                    tmp = lista[i]
                    lista[i] = lista[i+1]
                    lista[i+1] = tmp

    @staticmethod
    def selecao(lista):       
        for i in range(0, len(lista) -1):
            posMenor = i
            for j in range(i+1, len(lista)):
                if (lista[j] < lista[posMenor]):
                    posMenor = j
                
            if (i != posMenor):
                tmp = lista[i]
                lista[i] = lista[posMenor]
                lista[posMenor] = tmp
        
    @staticmethod
    def insercao(lista):   
        for i in range(1, len(lista)):
            tmp = lista[i]
            j = i - 1
            while (j >= 0):
                if (tmp < lista[j]):
                    lista[j + 1] = lista[j]
                else: 
                    break
                j -= 1
           
            lista[j + 1] = tmp
        
    @staticmethod
    def pente(lista):
        distancia = len(lista)

        houveTroca = True
        while (houveTroca and distancia > 1):
            distancia = int(distancia / 1.3)
            if (distancia < 1):
                distancia = 1
            houveTroca = False
            for i in range(0, len(lista) - distancia):
                if (lista[i] > lista[i+distancia]):
                    houveTroca = True
                    tmp = lista[i]
                    lista[i] = lista[i+distancia]
                    lista[i+distancia] = tmp


    @staticmethod
    def particiona(lista, ini, fim):
        pivo = ini # na bibliografia do método, é possível ser o ini, o fim ou uma posição sorteada
        while (fim > ini):
            while (fim > pivo and lista[fim] > lista[pivo]):
                fim = fim - 1

            if (fim > pivo):
                tmp = lista[pivo]
                lista[pivo] = lista[fim]
                lista[fim] = tmp
                pivo = fim

            ini = ini + 1
            while (ini < pivo and lista[ini] < lista[pivo]):
                ini = ini + 1

            if (ini < pivo):
                tmp = lista[pivo]
                lista[pivo]= lista[ini]
                lista[ini] = tmp
                pivo = ini
                
        return pivo

    @staticmethod
    def quickSort(lista, ini, fim):
        pivo = Ordenacao.particiona(lista, ini, fim);
        
        if (ini < pivo - 1):
            Ordenacao.quickSort(lista, ini, pivo - 1) # se existe lado esq do pivo, executa lado esq

        if (pivo + 1 < fim):
            Ordenacao.quickSort(lista, pivo + 1, fim) # se existe lado dir do pivo, executa lado dir

       
   