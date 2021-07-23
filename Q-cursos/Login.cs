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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cadastro cada = new Cadastro();
            cada.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conexao = "Server=192.168.15.5;Database=Cadastro;Uid=CadastroUsuario;Pwd=usuario2021";
            var connection = new MySqlConnection(conexao);
            var comand = connection.CreateCommand();
            MySqlCommand query = new MySqlCommand("select count(*) from cadastro where Email='" + textLogin.Text + "'and Senha='" + textSenha.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    MessageBox.Show("Usuario valido", "validação", MessageBoxButtons.OK);
                    Principal inicial = new Principal();
                    inicial.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
