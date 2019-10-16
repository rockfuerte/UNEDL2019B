 package examen;

import java.util.InputMismatchException;
 import java.util.Scanner;

public class Examen {
    
    public static void main(String args[]){
        Scanner entrada = new Scanner(System.in);
        Habitacion datos = new Habitacion();
        do { 
        try {   
        System.out.println("ingrese el largo del tapiz en metros: ");
        datos.setAlto(entrada.nextDouble());
        break;
        } catch (InputMismatchException e) {
                System.out.println("Error: solo puede ingresar numeros");
                entrada.nextLine();
            }
        } while (true);
        do { 
        try {  
        System.out.println("ingrese el ancho del tapiz en metros: ");
        datos.setAncho(entrada.nextDouble());
         break;
        } catch (InputMismatchException e) {
                System.out.println("Error: solo puede ingresar numeros");
                entrada.nextLine();
            }
        } while (true);
        do { 
        try {
        System.out.println("ingresa el costo por metro cuadrado: ");
        datos.setCosto(entrada.nextDouble());
        break;
        } catch (InputMismatchException e) {
                System.out.println("Error: solo puede ingresar numeros");
                entrada.nextLine();
            }
        } while (true);
        datos.setArea(datos.getAlto()*datos.getAncho());
        System.out.println("Costo del tapiz de la habitación: $"+datos.calcularCosto(datos.getArea(), +datos.getCosto()));    
    }   
}
