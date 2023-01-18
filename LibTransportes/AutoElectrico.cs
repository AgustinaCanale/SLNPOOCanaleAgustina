using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico: Vehiculos
    {
        

        public AutoElectrico(string motor, string color, string marca) : base(marca, motor)
        {
            Color = color;
        }

      
        public string Color { get; set; }

        public override string Frenar()
        {
            return "Esta frenando";
        }

        public override string Acelerar()
        {
            return "Velocidad Alta";
        }

        public override string ToString()
        {
            return base.Imprimir() + $"\nEl color de auto: {Color}";

        }
    }


}
