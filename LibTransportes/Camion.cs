using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion:Vehiculos
    {
        public Camion(string marca, string tipo, string motor) : base(marca, motor)
        {
            
            Tipo = tipo;
        }

       

        public string Tipo { get; set; }

        public Remolque Remolque { get; set; }

        public string QuitarRemolque()
        {
            Remolque= null;
            return "Se quito remolque";
        }

        public override string Acelerar()
        {
            return "Velocidad media";
        }

        public override string Frenar()
        {
            return "Se detuvo";
        }

        public override string ToString()
        {
            return base.Imprimir() + $"\nEl tipo de camion: {Tipo} "; 
             
        }


    }


}
