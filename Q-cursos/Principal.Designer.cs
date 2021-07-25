
namespace Q_cursos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtsAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaEditora = new System.Windows.Forms.ToolStripMenuItem();
            this.menLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftlAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsEditora = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.gtsGeral = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rtsAutor,
            this.TelaEditora,
            this.menLivro});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // rtsAutor
            // 
            this.rtsAutor.BackColor = System.Drawing.Color.Silver;
            this.rtsAutor.Name = "rtsAutor";
            this.rtsAutor.Size = new System.Drawing.Size(180, 22);
            this.rtsAutor.Text = "Autor";
            this.rtsAutor.Click += new System.EventHandler(this.rtsAutor_Click);
            // 
            // TelaEditora
            // 
            this.TelaEditora.BackColor = System.Drawing.Color.Silver;
            this.TelaEditora.Name = "TelaEditora";
            this.TelaEditora.Size = new System.Drawing.Size(180, 22);
            this.TelaEditora.Text = "Editora";
            this.TelaEditora.Click += new System.EventHandler(this.TelaEditora_Click);
            // 
            // menLivro
            // 
            this.menLivro.BackColor = System.Drawing.Color.Silver;
            this.menLivro.Name = "menLivro";
            this.menLivro.Size = new System.Drawing.Size(180, 22);
            this.menLivro.Text = "Livro";
            this.menLivro.Click += new System.EventHandler(this.menLivro_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftlAutores,
            this.ctsEditora,
            this.ftsLivro,
            this.gtsGeral});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ftlAutores
            // 
            this.ftlAutores.BackColor = System.Drawing.Color.Silver;
            this.ftlAutores.Name = "ftlAutores";
            this.ftlAutores.Size = new System.Drawing.Size(180, 22);
            this.ftlAutores.Text = "Autores";
            this.ftlAutores.Click += new System.EventHandler(this.ftlAutores_Click);
            // 
            // ctsEditora
            // 
            this.ctsEditora.BackColor = System.Drawing.Color.Silver;
            this.ctsEditora.Name = "ctsEditora";
            this.ctsEditora.Size = new System.Drawing.Size(180, 22);
            this.ctsEditora.Text = "Editoras";
            this.ctsEditora.Click += new System.EventHandler(this.ctsEditora_Click);
            // 
            // ftsLivro
            // 
            this.ftsLivro.BackColor = System.Drawing.Color.Silver;
            this.ftsLivro.Name = "ftsLivro";
            this.ftsLivro.Size = new System.Drawing.Size(180, 22);
            this.ftsLivro.Text = "Livros";
            this.ftsLivro.Click += new System.EventHandler(this.ftsLivro_Click);
            // 
            // gtsGeral
            // 
            this.gtsGeral.BackColor = System.Drawing.Color.Silver;
            this.gtsGeral.Name = "gtsGeral";
            this.gtsGeral.Size = new System.Drawing.Size(180, 22);
            this.gtsGeral.Text = "Geral";
            this.gtsGeral.Click += new System.EventHandler(this.gtsGeral_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsSistema});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // stsSistema
            // 
            this.stsSistema.BackColor = System.Drawing.Color.Silver;
            this.stsSistema.Name = "stsSistema";
            this.stsSistema.Size = new System.Drawing.Size(180, 22);
            this.stsSistema.Text = "Sistema";
            this.stsSistema.Click += new System.EventHandler(this.stsSistema_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(535, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 19);
            this.toolStripStatusLabel1.Text = "Bem Vindo ao Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Sistema de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rtsAutor;
        private System.Windows.Forms.ToolStripMenuItem TelaEditora;
        private System.Windows.Forms.ToolStripMenuItem menLivro;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftlAutores;
        private System.Windows.Forms.ToolStripMenuItem ctsEditora;
        private System.Windows.Forms.ToolStripMenuItem ftsLivro;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem stsSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gtsGeral;
    }
}