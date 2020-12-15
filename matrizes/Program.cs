﻿using System;

namespace matrizes {
    class Program {
        static void Main(string[] args) {
            //Inicia o programa recebendo o valor
            int n = int.Parse(Console.ReadLine());

            //Instancia o valor recebido para o tamanho da matriz
            //Iniciando a matriz com o parâmetro desejado.
            int[,] mat = new int[n, n];

            // o "FOR" abaixo tem a intenção de percorrer todas as linhas.
            for (int i = 0; i < n; i++) {

                // Relizo a leitura da linha digitada, recorto os espaços em branco para salvar os valores e guardo eles no vetor VALUES
                string[] values = Console.ReadLine().Split(' ');

                //Para cada linha preciso percorrer as colunas, portanto:
                for (int j = 0; j < n; j++) {
                    //Conforme entro nas casas da matriz, uso a referência dos valores salvos em VALUES e uso eles para cair na matriz
                    //Converto todos os strings para os ints colocando-os na matriz em suas devidas posições
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Percorre os valores iguais [0,0] [1,1], etc
            //A ideia é retornar a diagonal principal da matriz.
            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
           // "FOR" Simples para percorrer todos os campos da matriz.
           // for (int i = 0; i < n; i++) {
           //  for (int j = 0; j < n; j++) {
           //  } }

        }
    }
}
