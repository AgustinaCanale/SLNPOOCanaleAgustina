using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Ford", "Comercial","Gasolina");

            MessageBox.Show(camion.ToString() + "\n" + camion.Acelerar() + "\n" + camion.Frenar() + "\n" + camion.QuitarRemolque());
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();



        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

            AutoElectrico auto = new AutoElectrico("Electricidad", "Privado", "Tesla");

            MessageBox.Show(auto.ToString() + "\n" + auto.Acelerar() + "\n" + auto.Frenar());
        }
    }
    }

