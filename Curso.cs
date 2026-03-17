using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACT1._5
{
    public class Curso
    {
    
       private List <Alumno> Alumnos; 
    
    public Curso()
    {
    Alumnos = new List<Alumno>(); 

    }
    public Alumno agregarAlumno(string nombre , int dni)
    {
        cantFaltas = 0; 
       nombre = pedirString(" Ingrese el nombre del alumno/a a agregar. "); 
     dni = pedirInt(" Ingrese el DNI del Alumno/a"); 

    Alumno a = new Alumno(nombre, dni, cantFaltas);

       Alumnos.add(a); 
       


    }

    

    public string pedirString(string mensaje)
    { string texto; 
      System.Console.WriteLine(mensaje);
      texto = Console.ReadLine();
      return texto; 
    }

    public int pedirInt(string mensaje)
    {
        int numero; 
        System.Console.WriteLine(mensaje);
        numero = int.parse.consoleReadline(); 
        return numero; 

    }

    public double pedirDouble(string mensaje)
    {
        double numero; 
        System.Console.WriteLine(mensaje);
        numero = Console.ReadLine();
        return numero; 
    }

    }
}