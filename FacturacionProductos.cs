using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdministradores
{
    public partial class FacturacionProductos : Form
    {
        private SqlConnection Conexion = new SqlConnection("Server=RICHARD-PC;DataBase=VentasFacturacionPadrino;Integrated Security=true");
        DataTable datos = new DataTable();
        SqlCommand comando = new SqlCommand();
        private DataTable dt;

        public FacturacionProductos()
        {
            InitializeComponent();
            SiguienteIdFactura();
        }

       

        private void FacturacionProductos_Load(object sender, EventArgs e)
        {

        }

        private void SiguienteIdFactura()
        {
            SqlCommand cmd = new SqlCommand("SiguienteFacturaId", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            if (ds.Rows.Count > 0)
            {
                labelFactura.Text = ds.Rows[0]["SiguienteFactura"].ToString();
                labelMontoTotal.Text = ds.Rows[0]["SiguienteFactura"].ToString();

            }
        }

        private void groupBoxCarrito_Enter(object sender, EventArgs e)
        {

        }
        private void groupBoxCliente_Enter(object sender, EventArgs e)
        {

        }
        private void groupBoxProductos_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
