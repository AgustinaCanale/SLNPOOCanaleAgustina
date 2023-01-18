using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Modelos
{
    public class DBLineaAereaContext: DbContext
    {
        public DBLineaAereaContext() : base("KeyDB") { }

        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaAerea> LineasAereas { get; set; }
    }
}
