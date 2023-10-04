package pesquisa;

import java.util.ArrayList;

public class Pesquisa {
	public boolean pesquisaSequencial(ArrayList<Integer> lista, int valor) {
		for(int i = 0; i < lista.size(); i++) {
			if(valor == lista.get(i)) {
				return true;
			}
			if(valor < lista.get(i)) {
				break;
			}
		}
		return false;
	}
	
	public boolean pesquisaBinaria(ArrayList<Integer> lista, int valor) {
		int ini = 0;
		int fim = lista.size()-1;
		int meio;
		do {
			meio = (ini+fim)/2;
			if(valor == lista.get(meio)) {
				return true;
			}
			if(valor < lista.get(meio)) {
				fim = meio - 1;
			}else {
				ini = meio + 1;
			}
		}while(ini>=fim);
		return false;
	}
}
