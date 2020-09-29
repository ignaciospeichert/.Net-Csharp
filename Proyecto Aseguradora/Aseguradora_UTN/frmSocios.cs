using Actividades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseguradora_UTN
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }
            Actividad_Socios actividad_socios = new Actividad_Socios();
        private void frmSocios_Load(object sender, EventArgs e)
        {          
            dtgSocios.DataSource = actividad_socios.ReadAll();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            actividad_socios.Read("1");
        }
    }
}
