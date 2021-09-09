using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Q_cursos
{
    public partial class Consultar_Autores : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        string strSQL;
        public Consultar_Autores()
        {
            InitializeComponent();
        }

        private void Consultar_Autores_Load(object sender, EventArgs e)
        {
            pnlEditoras.Location = new Point(this.Width / 2 - 473, this.Height / 2 - 292);
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {
            pnlEditoras.Enabled = true;
        }

        private void Consultar_Autores_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "Select * from autor";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAutores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
