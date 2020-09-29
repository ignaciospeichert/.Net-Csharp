using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;
        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta,miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);
                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }

        private void MuestraPedidos()
        {
            string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID = P.cCLIENTE " +
                "where C.ID = @ClienteId";
            SqlCommand command = new SqlCommand(consulta,miConexionSql);

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(command);
            using (miAdaptadorSql)
            {
                command.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                DataTable pedidosTabla = new DataTable();
                
                miAdaptadorSql.Fill(pedidosTabla);

                listaPedidos.DisplayMemberPath = "fechaPedido";
                listaPedidos.SelectedValuePath = "Id";
                listaPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }
        private void MuestraTodosPedidos()
        {
            string consulta = "SELECT CONCAT(cCliente, ' ', fechaPedido, ' ' , formaPago) AS InfoCompleta FROM PEDIDO";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta,miConexionSql);

            using(miAdaptadorSql)
            {
                DataTable dt = new DataTable();
                miAdaptadorSql.Fill(dt);

                todosPedidos.DisplayMemberPath = "InfoCompleta";
                todosPedidos.SelectedValuePath = "Id";
                todosPedidos.ItemsSource = dt.DefaultView;
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
            MuestraTodosPedidos();
            
        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
