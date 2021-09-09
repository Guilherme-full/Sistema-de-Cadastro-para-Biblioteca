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
    public partial class Cadastro_de_Editora : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_de_Editora()
        {
            InitializeComponent();
        }

        private void pbEditora_Click(object sender, EventArgs e)
        {
            pnlEditora.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "insert into editora(nome_editora, endereço, numero, email) values (@nome_editora, @endereço, @numero, @email)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome_editora", textNomeDaEditora.Text);
                comando.Parameters.AddWithValue("@endereço", textEndereço.Text);
                comando.Parameters.AddWithValue("@numero", textNúmero.Text);
                comando.Parameters.AddWithValue("@email", textEmailEditora.Text);
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
            textNomeDaEditora.Text = "";
            textEndereço.Text = "";
            textNúmero.Text = "";
            textEmailEditora.Text = "";
            textNomeDaEditora.Focus();
        }
    }
}
