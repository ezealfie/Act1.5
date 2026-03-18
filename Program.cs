namespace ACT1._5;

class Program
{        

    static void Main(string[] args)
    {
     Curso curso = new Curso();

        int opcion; 
        do
        {
            imprimirMenu();
            opcion = ingresarIntC();
            switch (opcion)
            {
            case 1:
            opcion1(curso);
            break;
            case 2:
            opcion2();
            break;
            case 3:
            opcion3();
            break;
            case 4:
            opcion4();
            break;
            default: 
            System.Console.WriteLine("Gracias por utilizar el programa");
            break;
        }   

    
        } while (opcion != 5);




    }

static void imprimirMenu(){
    Console.WriteLine("1. Agregar nuevo alumno");
    Console.WriteLine("2. Buscar un alumno por su dni");
    Console.WriteLine("3. Cargar falta");
    Console.WriteLine("4. Mostrar alumnos libres");
    Console.WriteLine("5. Salir");

}
static int ingresarIntC(){
    int opcion = 0;
while (opcion!= 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 5)
{
    Console.WriteLine("Ingrese una opción entre las posibles");
opcion = int.Parse(Console.ReadLine());

}
return opcion;

}


static void opcion1(Curso curso){
    string nombre = pedirString(" Ingrese el nombre del alumno/a a agregar. "); 
    int dni = pedirInt(" Ingrese el DNI del Alumno/a"); 
curso.agregarAlumno(nombre, dni);
}
static void opcion2(){

}
static void opcion3(){

}
static void opcion4(){

}

static string pedirString(string mensaje)
    { string texto; 
      System.Console.WriteLine(mensaje);
      texto = Console.ReadLine();
      return texto; 
    }

    static int pedirInt(string mensaje)
    {
        int numero; 
        System.Console.WriteLine(mensaje);
        numero = int.Parse(Console.ReadLine()); 
        return numero; 

    }
}
