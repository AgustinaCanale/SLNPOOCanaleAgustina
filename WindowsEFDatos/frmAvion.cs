using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Modelos;
using WindowsEFDatos.Dac;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            Avion avion = new Avion()
            {
                Denominacion = txtNombre.Text,
                Capacidad = 200,
                IdLinea = 1
            };

            int filasAfectadas = abmAvion.Insert(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avion insertado");
                MostrarAvion();
            }




        }

        private void MostrarAvion()
        {
            gridAvion.DataSource = abmAvion.SelectAll();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAvion();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
