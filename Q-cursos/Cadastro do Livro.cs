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
    public partial class Cadastro_do_Livro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_do_Livro()
        {
            InitializeComponent();
        }

        private void pbEditora_Click(object sender, EventArgs e)
        {
            plEditora.Enabled = true;
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.5;Database=Biblioteca;Uid=Cadastros;Pwd=cadastrosSistema2021");
                strSQL = "insert into livro(nome_livro, isbn, preco, id_autor, id_editora) values (@nome_livro, @isbn, @preco, @id_autor, @id_editora)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome_livro", textNomeDoLivro.Text);
                comando.Parameters.AddWithValue("@isbn", textISBN.Text);
                comando.Parameters.AddWithValue("@preco", textPreco.Text);
                comando.Parameters.AddWithValue("@id_autor", textIDdoAutor.Text);
                comando.Parameters.AddWithValue("@id_editora", textIDdaEditora.Text);
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
    }
}
