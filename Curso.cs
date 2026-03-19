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
    public bool agregarAlumno(string nombre, int dni)
    { 
        bool v = false;
        if (buscarExistente(dni)==false)
        {
            Alumno a = new Alumno(dni, nombre);
            Alumnos.Add(a); 
            v = true;
        }
        return v;
    }

    

    private bool buscarExistente(int dni){
       int i = 0;
       if (Alumnos.Count > 0){
            while(i < Alumnos.Count && Alumnos[i].getDNI() != dni ){
                i++;
            }
            if (i > Alumnos.Count) return false;
                else return true;
       } else return false;
    }

    public double pedirDouble(string mensaje)
    {
        double numero; 
        System.Console.WriteLine(mensaje);
        numero = double.Parse(Console.ReadLine());
        return numero; 
    }

    }
}