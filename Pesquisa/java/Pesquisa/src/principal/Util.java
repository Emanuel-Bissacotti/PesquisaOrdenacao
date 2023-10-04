package principal;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Random;
import java.util.Scanner;

import pesquisa.Pesquisa;

public class Util {
	
	private ArrayList<Integer> popularVetor(ArrayList<Integer> lista, int qtdValores) {
		int i = 0;
		while(i < qtdValores) {
			Random rand = new Random();
			lista.add(rand.nextInt());
			i++;
		}
		return lista;
	}
	
	public void init() {
		System.out.println("Quantos valores deseja? ");
		Scanner sc = new Scanner(System.in);
		int qtd = sc.nextInt();
		ArrayList<Integer> lista = new ArrayList<Integer>();
		lista = popularVetor(lista, qtd);
//		exibir(lista);
		Collections.sort(lista);
//		exibir(lista);
		System.out.println("Qual valor deseja procurar");
		int pesquisa = sc.nextInt();
		Pesquisas(lista, pesquisa);
	}
	
	private void Pesquisas(ArrayList<Integer> lista, int pesquisa) {
		// TODO Auto-generated method stub
		Pesquisa p = new Pesquisa();
		double tempoInicio, tempoFim;
		
		tempoInicio = System.nanoTime();
        p.pesquisaSequencial(lista, pesquisa);
        tempoFim = System.nanoTime();
        System.out.println("Tempo (ms) pesquisa Sequecial: " + (tempoFim - tempoInicio)/1000000);
        
        tempoInicio = System.nanoTime();
        p.pesquisaBinaria(lista, pesquisa);
        tempoFim = System.nanoTime();
        System.out.println("Tempo (ms) pesquisa Binaria: " + (tempoFim - tempoInicio)/1000000);
        
        tempoInicio = System.nanoTime();
        lista.contains(pesquisa);
        tempoFim = System.nanoTime();
        System.out.println("Tempo (ms) contains: " + (tempoFim - tempoInicio)/1000000);
	}

	private void exibir(ArrayList<Integer> lista) {
		for (Integer integer : lista) {
			System.out.println(integer);
		}
	}
}
