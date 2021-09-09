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
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Cadastro;Uid=CadastroUsuario;Pwd=usuario2021");
                strSQL = "insert into cadastro(nome, sobrenome, email, cidade, estado, senha) values (@nome, @sobrenome, @email, @cidade, @estado, @senha)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", textNome.Text);
                comando.Parameters.AddWithValue("@sobrenome", textSobrenome.Text);
                comando.Parameters.AddWithValue("@email", textEmail.Text);
                comando.Parameters.AddWithValue("@cidade", textCidade.Text);
                comando.Parameters.AddWithValue("@estado", textEstado.Text);
                comando.Parameters.AddWithValue("@senha", textSenha.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Executado com Sucesso");
                Login entrada = new Login();
                entrada.Show();
                this.Visible = false;
            }
            catch(Exception ex)
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

        private void btnTelaDeLogin_Click(object sender, EventArgs e)
        {
            Login entrada = new Login();
            entrada.Show();
            this.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            textSobrenome.Text = "";
            textEmail.Text = "";
            textCidade.Text = "";
            textEstado.Text = "";
            textSenha.Text = "";
            textNome.Focus();
        }
    }
}
