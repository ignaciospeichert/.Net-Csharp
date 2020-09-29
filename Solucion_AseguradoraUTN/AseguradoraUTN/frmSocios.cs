using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividades;

namespace AseguradoraUTN
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }     
        Actividad_Socio actividades_socios = new Actividad_Socio();

        private void frmSocios_Load(object sender, EventArgs e)
        {            
            dtg_socios.DataSource = actividades_socios.ReadAll();
            if (txtDni.Text != "")
                actividades_socios.Read(txtDni.Text);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Socio socio = new Entidades.Socio();

            socio.DNI = txtDni.Text;
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.Direccion = txtDireccion.Text;
            socio.Telefono = txtTelefono.Text;
            socio.Email = txtEmail.Text;

            bool estado = actividades_socios.Create(socio);

            if (estado)
                MessageBox.Show("El socio fue agregado correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

            dtg_socios.DataSource = actividades_socios.ReadAll();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Socio socio = new Entidades.Socio();

            socio.DNI = txtDni.Text;
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.Direccion = txtDireccion.Text;
            socio.Telefono = txtTelefono.Text;
            socio.Email = txtEmail.Text;

            actividades_socios.Update(socio);
            Limpiar();

            dtg_socios.DataSource = actividades_socios.ReadAll();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidades.Socio socio = new Entidades.Socio();

            socio.DNI = txtDni.Text;

            actividades_socios.Delete(socio);
            

            dtg_socios.DataSource = actividades_socios.ReadAll();
            Limpiar();
        }
        private void Limpiar()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length != 0 )

            txtDni.Text = actividades_socios.Read(txtDni.Text).DNI;
            txtNombre.Text = actividades_socios.Read(txtDni.Text).Nombre;
            txtApellido.Text = actividades_socios.Read(txtDni.Text).Apellido;
            txtDireccion.Text = actividades_socios.Read(txtDni.Text).Direccion;
            txtTelefono.Text = actividades_socios.Read(txtDni.Text).Telefono;
            txtEmail.Text = actividades_socios.Read(txtDni.Text).Email;
        }   

        private void txtDni_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {                
                txtNombre.Text = actividades_socios.Read(txtDni.Text).Nombre;
                txtApellido.Text = actividades_socios.Read(txtDni.Text).Apellido;
                txtDireccion.Text = actividades_socios.Read(txtDni.Text).Direccion;
                txtTelefono.Text = actividades_socios.Read(txtDni.Text).Telefono;
                txtEmail.Text = actividades_socios.Read(txtDni.Text).Email;

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el socio");
                Limpiar();
            }               
            
        }

        private void dtg_socios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = dtg_socios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtg_socios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtg_socios.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dtg_socios.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtg_socios.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dtg_socios.CurrentRow.Cells[5].Value.ToString();
        }      
    }
}
