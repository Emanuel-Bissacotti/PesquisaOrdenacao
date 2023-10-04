class Pesquisa:
    def pesquisaSequencial(lista, valor):
        i = 0
        while(i < len(lista)):
            if(valor == lista[i]):
                return True
            if(valor < lista[i]):
                break
            i=i+1
        return False
	
    def pesquisaBinaria(lista, valor):
        ini = 0
        fim = len(lista) - 1
        while(ini >= fim):
            meio = (ini+fim)/2
            if(valor == lista[meio]):
                return True
 			
                if(valor < lista[meio]):
                    fim = meio - 1
                else:
                    ini = meio + 1
                
        return False