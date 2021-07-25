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
    public partial class Editoras_Cadastradas : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Editoras_Cadastradas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEditora.Enabled = true;
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.5;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "Select * from editora";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEditora.DataSource = dt;
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

        private void Editoras_Cadastradas_Load(object sender, EventArgs e)
        {
            pnlEditora.Location = new Point(this.Width / 2 - 555, this.Height / 2 - 320);
        }
    }
}
