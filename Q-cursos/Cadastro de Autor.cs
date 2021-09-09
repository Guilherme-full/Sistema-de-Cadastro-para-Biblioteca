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
    public partial class Cadastro_de_Autor : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public Cadastro_de_Autor()
        {
            InitializeComponent();
        }

        private void pbAdicionar_Click(object sender, EventArgs e)
        {
            pnCad.Enabled = true;
        }

        private void btnCadastroAutor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "insert into autor(nome_completo, estado, cidade, email) values (@nome_completo, @estado, @cidade, @email)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome_completo", textNomeCompletoAutor.Text);
                comando.Parameters.AddWithValue("@estado", textEstadoAutor.Text);
                comando.Parameters.AddWithValue("@cidade", textCidadeAutor.Text);
                comando.Parameters.AddWithValue("@email", textEmailAutor.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrados com Sucesso", "Cadastro", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar os dados", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNomeCompletoAutor.Text = "";
            textEstadoAutor.Text = "";
            textCidadeAutor.Text = "";
            textEmailAutor.Text = "";
            textNomeCompletoAutor.Focus();
        }
    }
}
