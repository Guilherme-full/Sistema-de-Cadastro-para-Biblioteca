using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_cursos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rtsAutor_Click(object sender, EventArgs e)
        {
            Cadastro_de_Autor cadast = new Cadastro_de_Autor();
            cadast.Show();
        }

        private void TelaEditora_Click(object sender, EventArgs e)
        {
            Cadastro_de_Editora cadEdi = new Cadastro_de_Editora();
            cadEdi.Show();
        }

        private void menLivro_Click(object sender, EventArgs e)
        {
            Cadastro_do_Livro cadLivro = new Cadastro_do_Livro();
            cadLivro.Show();
        }

        private void ftlAutores_Click(object sender, EventArgs e)
        {
            Consultar_Autores conAutor = new Consultar_Autores();
            conAutor.Show();
        }

        private void ctsEditora_Click(object sender, EventArgs e)
        {
            Editoras_Cadastradas ediCad = new Editoras_Cadastradas();
            ediCad.Show();
        }

        private void ftsLivro_Click(object sender, EventArgs e)
        {
            Livros_Cadastrados livCAD = new Livros_Cadastrados();
            livCAD.Show();
        }

        private void gtsGeral_Click(object sender, EventArgs e)
        {
            Geral ger = new Geral();
            ger.Show();
        }
    }
}
