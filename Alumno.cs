using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACT1._5
{
    public class Alumno
    {
        private int dni; 
        private string nombre; 
        private double cantFaltas; 
        
        public Alumno( int dni, string nombre){
          this.dni = dni; 
          this.nombre = nombre; 
          this.cantFaltas = 0;    
        }
        public string getNombre(){
            return nombre; 

        }
        public int getDNI(){
            return dni; 

        }
        public double getFaltas(){
            return cantFaltas; 
        }
    }

}