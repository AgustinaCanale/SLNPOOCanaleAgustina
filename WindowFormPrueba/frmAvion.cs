using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Modelos;

namespace WindowFormPrueba
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

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(txtId.Text),
                Denominacion = txtNombre.Text,
                Capacidad = 200,
                IdLinea = 1
            };


            int filasAfectadas = abmAvion.Delete(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAvion();

            }
        }


        private void MostrarAvion()
        {
            gridAvion.DataSource = abmAvion.SelectAll();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAvion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(txtId.Text),
                Denominacion = txtNombre.Text,
                Capacidad = 200,
                IdLinea = 1
            };

            int filasAfectadas = abmAvion.Update(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarAvion();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int IdAvion = Convert.ToInt32(txtId.Text);

            Avion alumno = abmAvion.SelectWhereById(IdAvion);
            MessageBox.Show(alumno.Denominacion);

        }
    }

}
