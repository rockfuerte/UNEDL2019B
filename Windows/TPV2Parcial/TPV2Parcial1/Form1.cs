/*                                         ----------------PREGUNTAS---------------
             1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
             R= Son como clases especiales que se utilizan para manejar pues distintos valores u objetos.
             Existen dos tipos que son el: non generic collections y generic collections.
             2. Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
             R= Existen en C# el contexto seguro y el no seguro, el codigo que se queda fuera del contexto seguro,
             se queda fuera del garbage collector. Cualquier codigo que use apuntadores lo requiere.
             3. Mencione al menos tres clases que se utilizan en lo y proporcione brevemente la idea central de
            las mismas.
            R= FileStream: Ese lee y escribe bytes desde y hacia un archivo en concreto.
               MemoryStream: Lee y escribe los bytes desde y hacia la memoria.
               BufferedStream: Lee y escribe los bytes desde y hacia otros streams que hay para mejorar nuestras operaciones
               de entrada y salida.
            4. Explique la diferencia entre los siguientes códigos en csharp
            a. Console.Writeline ("resultado: (*ptr) ").
            Imprimirá el resultado de la operación sin forzarla a que sea de tipo entero.
            b. Console.WriteLine("resultado: ((int)ptr)")
            Imprimirá el resultado de la operación forzada a imprimirse con números enteros.
            5. Mencione al menos tres caracteristicas de las excepciones (Exceptions).
            R= Una excepción es un evento inesperado que aparece cuando nosotros compilamos un programa.
               Una excepción es la respuesta a un circunstancia cuando nosotros ejecutamos nuestro programa, por ejemplo que intenta
               acceder a un objeto que esta fuera de rango u operaciones sin lógica.
               Se pueden manejar usando herramientas como el "try" "catch" y "finally".
            6. En Java, mencione y describa los tres tipos de excepciones.
            R= Checked exceptions: Cuando una aplicación se anticipa y se recupera (java.io.FileNotFoundException).
               Uncheked excpetions: Error externo a la aplicación y no se puede salvar (java.io.IOError).
               Runtime exceptions: Adentro de la aplicación usualmente no se puede salvar o recuperar (NullPointerException).
            7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para usarlas.
            R= Son las que le dan instrucciones al compilador para que pueda procesar información antes de que se compilen
            por si mismas, se deben iniciar con un # y deben ser las únicas instrucciones en la linea.
            8. Explique las diferencias entre ArrayList, Sorted List Hash Table.
            R= El Arraylist es el que almacena objetos sin importar de que sean  y los convierte en tipos de arreglo, el sortedlist
            almacena pares donde uno es la llave y otro el valor, acomoda elementos usando la llave, y el hashtable lo que hace es que
            es similar al sortedlist pero recupera los valores utilizando la llave ya obtenida.
            9. Describa las para que sirven StreamReader y StreamWriter
            R= Pues son unas clases de apoyo que permiten la lectura y escritura convirtiendo los bytes en caracteres y viceversa.
            10. Explique el funcionamiento del algoritmo Quicksort
            R= El algoritmo de Quicksort divide la estructura en dos y ordena cada mitad recursivamente.
            11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
            R= El System.out nos puede servir para imprimir textos, caracteres, et, System.in puede ser para declarar atributos
            o cosas como el Scanner y el System.err sirve para imprimir mensajes de error los cuales se subrayan en color rojo.
            12. Explique cuáles son las ventajas de utilizar "generic collections"
            R= Bueno la ventaja es que este tipo de colecciones pueden almacenar cualquier tipo de elementos y 
            se impactan el rendimiento en su uso por el boxing/unboxing.
            13 Desarrolle en C#, un programa en Windows Forms llamado TPV2doParcial que permita crear un
            archivo, lo lea y permita escribir en el. El programa debe permitir la captura de una lista de palabras
            y al finalizar la captura, debe reportar la cantidad total de palabras, las palabras repetidas y la
            cantidad de ocurrencias. Capture las excepciones necesarias. Al terminar, suba su codigo a su
            repositorio y escriba el SHA correspondiente en el examen
             */
using System;
using System.Collections;
using System.Windows.Forms;

namespace TPV2doPArcial
{
    
    public partial class Form1 : Form
    {
        ArrayList word = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            word.Add(textBox1.Text);
            MessageBox.Show("Agregaste la palabra con exito");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < word.Count; i++)
            {
                int cont = 0;
                for (int j = 0; j < word.Count; j++)
                {
                    if (i != j)
                    {
                        if (word[i].ToString() == word[j].ToString())
                        {
                            word[j] = "0";
                            cont++;
                            
                        }
                    }
                }
                if (cont > 0)
                {
                    if (word[i].ToString() != "0")
                    {
                        listBox1.Items.Add(word[i].ToString() + " La palabra se repite " + cont + "veces");
                    }
                }
            }
          
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
