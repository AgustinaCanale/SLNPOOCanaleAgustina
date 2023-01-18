using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculos
    {
        public Vehiculos(string marca, string motor)
        {
            Marca = marca;
            Motor = motor;
        }

        public string Marca { get; set; }
        public string Motor { get; set; }

        public abstract string Acelerar();
        public abstract string Frenar();
        public virtual string Imprimir()
        {
            return $"Tipo motor: {Motor}" +
                $"\nNombre de la marca: {Marca}" 
                ;
        }
    }
}
