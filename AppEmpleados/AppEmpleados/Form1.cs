using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DateTime fechanac=dtipFechaN.Value.ToString("dd/mm/año");
             DateTime fechaing=dtpFechaI.Value.ToString("dd/mm/año");
             Empleado empleado1 = new Empleado(txtNombre.Text, txtApellido.Text, cmbSexo.SelectedItem.ToString, fechananc, fechaing, float.Parse(txtSalario.Text));
        } 
    }
}
