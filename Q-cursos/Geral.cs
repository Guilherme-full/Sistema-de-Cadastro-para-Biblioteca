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
    public partial class Geral : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Geral()
        {
            InitializeComponent();
        }

        private void pbGeral_Click(object sender, EventArgs e)
        {
            pnlGeral.Enabled = true;
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = " Select pp.nome_livro as Livro, pc.nome_completo as Autor, po.nome_editora as Editora from livro pp inner join autor pc on pp.id_autor = pc.id_autor inner join editora po on pp.id_editora = po.id_editora";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGeral.DataSource = dt;
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

        private void Geral_Load(object sender, EventArgs e)
        {
            pnlGeral.Location = new Point(this.Width / 2 - 555, this.Height / 2 - 278);
        }
    }
}
