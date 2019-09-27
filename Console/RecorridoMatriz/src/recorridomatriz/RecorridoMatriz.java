/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package recorridomatriz;

public class RecorridoMatriz {
   public static void main (String [] args) {
   int a,b;
 int matriz[][] = {{1,3,5,7}, {4,7,9,7}, {2,6,8,0}, {2,4,5,2}};
      for (a=0; a<matriz.length; a++) { // Inicializamos ciclo for de filas
  for (b=0; b < matriz[a].length; b++) { // Inicializamos ciclo for de columnas
    System.out.print (matriz[a][b]+" "); // Imprimimos valores de la matriz
  } // Se cierra ciclo for de columnas
  System.out.println(" "); // Imprimimos los espacios de filas
          System.out.println("");
} System.out.println(matriz[0][0]+""+
        matriz[1][0]+
        matriz[2][0]+
        matriz[3][0]+
        matriz[3][1]+
        matriz[2][1]+
        matriz[1][1]+
        matriz[0][1]+
        matriz[0][2]+
        matriz[1][2]+
        matriz[2][2]+
        matriz[3][2]+
        matriz[3][3]+
        matriz[2][3]+
        matriz[1][3]+
        matriz[0][3]);
    } // Se cierra metodo   
   }

