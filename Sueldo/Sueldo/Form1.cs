using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          private void button1_Click(object sender, EventArgs e)
        {
            txtbonificacion.Clear();
            txthextrastrabajadas.Clear();
            txthnormalestrabajadas.Clear();
            txtpagohextra.Clear();
            txtpagohnormal.Clear();
            txtsueldobruto.Clear();
            txtsueldoneto.Clear();
            ckbonificacion.Checked = false;
            nphijos.Value = 0;
           
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            //declaramos variables
            int hnormales, hextras;
            double phnormal, phextras, sueldobruto, sueldoneto, bonificacion;
            byte nhijos;
            Boolean marcado;

           //entrada de datos
            hnormales = Convert.ToInt32(txthnormalestrabajadas.Text);
            hextras = Convert.ToInt32(txthextrastrabajadas.Text);
            phnormal = Convert.ToDouble(txtpagohnormal.Text);
            phextras = Convert.ToDouble(txtpagohextra.Text);
            nhijos = Convert.ToByte(nphijos.Value);
            marcado = Convert.ToBoolean(ckbonificacion.Checked);

            //bonificacion arranca en 0

            bonificacion = 0.0;

            //proceso

            sueldoneto = hnormales * phnormal + hextras * phextras;
                        
            //vemos si tiene bonificacion            
            if (marcado == true)
                bonificacion = nhijos * 20;

            sueldobruto = sueldoneto + bonificacion;

            //datos de salida

            txtsueldobruto.Text = Convert.ToString(sueldobruto);
            txtsueldoneto.Text = Convert.ToString(sueldoneto);
            txtbonificacion.Text = Convert.ToString(bonificacion);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
