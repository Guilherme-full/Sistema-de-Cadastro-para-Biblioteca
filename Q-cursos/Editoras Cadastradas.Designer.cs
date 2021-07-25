
namespace Q_cursos
{
    partial class Editoras_Cadastradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editoras_Cadastradas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEditora = new System.Windows.Forms.DataGridView();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditora = new System.Windows.Forms.Panel();
            this.Exibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEditora.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(290, -100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autores Cadastrados";
            // 
            // dgvEditora
            // 
            this.dgvEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditora.Location = new System.Drawing.Point(3, 55);
            this.dgvEditora.Name = "dgvEditora";
            this.dgvEditora.Size = new System.Drawing.Size(1083, 471);
            this.dgvEditora.TabIndex = 0;
            // 
            // pbImagem
            // 
            this.pbImagem.BackColor = System.Drawing.Color.Gray;
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(794, -100);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(113, 61);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 6;
            this.pbImagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.Location = new System.Drawing.Point(374, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Editoras Cadastradas";
            // 
            // pnlEditora
            // 
            this.pnlEditora.Controls.Add(this.Exibir);
            this.pnlEditora.Controls.Add(this.dgvEditora);
            this.pnlEditora.Enabled = false;
            this.pnlEditora.Location = new System.Drawing.Point(17, 94);
            this.pnlEditora.Name = "pnlEditora";
            this.pnlEditora.Size = new System.Drawing.Size(1109, 536);
            this.pnlEditora.TabIndex = 11;
            // 
            // Exibir
            // 
            this.Exibir.BackColor = System.Drawing.Color.Silver;
            this.Exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir.Location = new System.Drawing.Point(3, 16);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(101, 33);
            this.Exibir.TabIndex = 4;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = false;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // Editoras_Cadastradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1138, 632);
            this.Controls.Add(this.pnlEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editoras_Cadastradas";
            this.Text = "Editoras Cadastradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Editoras_Cadastradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEditora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEditora;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEditora;
        private System.Windows.Forms.Button Exibir;
    }
}