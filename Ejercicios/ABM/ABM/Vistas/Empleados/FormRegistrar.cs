using ABM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM.Vistas.Empleados
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            /*instanciar SQLCONNECTION
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cs_abm"].ConnectionString
                );
            cn.Open();
            MessageBox.Show("Conexion Exitosa");
            cn.Close();
            */

            if (txt_apellido.Text.Trim().Equals(""))
            {
                txt_apellido.Focus();
                MessageBox.Show("Completar Apellido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_nombre.Text.Trim().Equals(""))
            {
                txt_nombre.Focus();
                MessageBox.Show("Completar Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_dni.Text.Trim().Equals(""))
            {
                txt_dni.Focus();
                MessageBox.Show("Completar DNI", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_dni.Text.Trim().Length != 8)
            {
                txt_dni.Focus();
                MessageBox.Show("Completar DNI de 8 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_direccion.Text.Trim().Equals(""))
            {
                txt_direccion.Focus();
                MessageBox.Show("Completar Direccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgv_telefonos.Rows.Count == 0)
            {
                MessageBox.Show("Ingresar al menos un telefono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var empleado = new Clases.Empleado(

                txt_apellido.Text.Trim().ToUpper(),
                txt_nombre.Text.Trim().ToUpper(),
                txt_dni.Text.Trim(),
                cbo_genero.Text,
                cbo_estado_civil.Text,
                txt_direccion.Text.Trim(),
                cbo_distrito.SelectedValue.ToString()

                );

                int ultimo_id = empleado.Registrar();

            }

            var empleado = new Clases.Empleado(
                
                txt_apellido.Text.Trim().ToUpper(),
                txt_nombre.Text.Trim().ToUpper(),
                txt_dni.Text.Trim(),
                cbo_genero.Text,
                cbo_estado_civil.Text,
                txt_direccion.Text.Trim(),
                cbo_distrito.SelectedValue.ToString()         

                );

            int ultimo_id = empleado.Registrar();
            

        }

        private void FormRegistrar_Load(object sender, EventArgs e)

        {          
            
            cbo_genero.SelectedIndex = 0;
            cbo_estado_civil.SelectedIndex = 0;
            cbo_operador.SelectedIndex = 0;

            // Instanciar la clase Ubigeo
            var ubigeo = new Clases.UbiGeo();
            var tabla = ubigeo.ListarDepartamentos(); ;

            
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }

            
        }

        private void cbo_departamento_SelectedValueChanged(object sender, EventArgs e)
        {
            // Instanciar la clase Ubigeo
            var ubigeo = new Clases.UbiGeo();
            var departamentoId = cbo_departamento.SelectedValue.ToString();
            var tabla = ubigeo.ListarProvinciasPorDepartamentoId(departamentoId); ;


            if (tabla.Rows.Count > 0)
            {
                cbo_provincia.DataSource = tabla;
                cbo_provincia.DisplayMember = "NOMBRE_PROVINCIA";
                cbo_provincia.ValueMember = "PROVINCIA_ID";
            }


        }

        private void cbo_provincia_SelectedValueChanged(object sender, EventArgs e)
        {
            var ubigeo = new Clases.UbiGeo();
            var provinciaId = cbo_provincia.SelectedValue.ToString();
            var tabla = ubigeo.ListarDistritosPorProvinciaId(provinciaId); ;


            if (tabla.Rows.Count > 0)
            {
                cbo_distrito.DataSource = tabla;
                cbo_distrito.DisplayMember = "NOMBRE_DISTRITO";
                cbo_distrito.ValueMember = "DISTRITO_ID";
            }

            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int numero_filas = dgv_telefonos.Rows.Count;

            if (numero_filas == 0)

            {
                AgregarTelefonos();
            }
            else
            {
                bool existe = false;
                string numero = txt_numero.Text;

                for (int i = 0; i < numero_filas; i++)
                {
                    if (numero.Equals(dgv_telefonos.Rows[i].Cells[1].Value.ToString()))
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Este telefono ya fue ingresado");
                }
                else
                {
                    AgregarTelefonos();
                }
            }
           
            
            
        }

        private void AgregarTelefonos()
        {
            string operador = cbo_operador.Text;
            string numero = txt_numero.Text;
            dgv_telefonos.Rows.Add(operador, numero, "Eliminar");
        }
    }
}
