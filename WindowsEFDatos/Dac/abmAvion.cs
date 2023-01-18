using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Dac
{
    public class abmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static int Insert(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }

        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }

        public static int Delete(Avion avion)
        {


            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);
            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);
                return context.SaveChanges();
            }

            return 0;
        }

        public static int Update(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);
            avionOrigen.Denominacion = avion.Denominacion;
            return context.SaveChanges();

        }

        public static Avion SelectWhereById(int IdAvion)
        {
            return context.Aviones.Find(IdAvion);

        }
    }
}
