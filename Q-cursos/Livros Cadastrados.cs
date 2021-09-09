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
    public partial class Livros_Cadastrados : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Livros_Cadastrados()
        {
            InitializeComponent();
        }
        
        private void pbImagemLi_Click(object sender, EventArgs e)
        {
            pnlLivros.Enabled = true;
        }

        private void Livros_Cadastrados_Load(object sender, EventArgs e)
        {
            pnlLivros.Location = new Point(this.Width / 2 - 507, this.Height / 2 - 292);
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "Select * from livro";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLivros.DataSource = dt;
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
