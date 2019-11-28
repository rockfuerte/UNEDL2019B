/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herencia;



public class Main {
    public static void main (String [] args){
        Hijo Pablo = new Hijo("Cafés","Lacio","Café","Claro", (float) 1.72,"Sí","Sí");
        Pablo.Mostrar(); //Llamamos los atributos que heredamos en el metodo de la clase hijo
        
        //Llamamos con nuestro objeto los metodos que tenga nuestra clase padre, ya que los hemos heredado directamente
        System.out.println("\nLos métodos que he heredado");
        Pablo.Caracter();
        Pablo.GestoBoca();
        Pablo.Risa();
        
        //Llamamos con nuestro objeto los metodos que he aprendido de otras personas
        System.out.println("\nLos metodos que he aprendido de otras partes externas a mi herencia (padres)");
        System.out.println("Amigos: ");
        Pablo.Expresion();
        System.out.println("Maestros: ");
        Pablo.FormaDeTrabajo();
        System.out.println("Jefes anteriores");
        Pablo.Disciplina();
        
    }
}