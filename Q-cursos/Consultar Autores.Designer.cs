
namespace Q_cursos
{
    partial class Consultar_Autores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Autores));
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.Exibir = new System.Windows.Forms.Button();
            this.pnlEditoras = new System.Windows.Forms.Panel();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.pnlEditoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagem
            // 
            this.pbImagem.BackColor = System.Drawing.Color.Silver;
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(911, 9);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(113, 61);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 1;
            this.pbImagem.TabStop = false;
            this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
            // 
            // Exibir
            // 
            this.Exibir.BackColor = System.Drawing.Color.Silver;
            this.Exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir.Location = new System.Drawing.Point(3, 20);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(101, 33);
            this.Exibir.TabIndex = 3;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = false;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // pnlEditoras
            // 
            this.pnlEditoras.Controls.Add(this.Exibir);
            this.pnlEditoras.Controls.Add(this.dgvAutores);
            this.pnlEditoras.Enabled = false;
            this.pnlEditoras.Location = new System.Drawing.Point(11, 76);
            this.pnlEditoras.Name = "pnlEditoras";
            this.pnlEditoras.Size = new System.Drawing.Size(1013, 583);
            this.pnlEditoras.TabIndex = 4;
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(3, 59);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(999, 471);
            this.dgvAutores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autores Cadastrados";
            // 
            // Consultar_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1138, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEditoras);
            this.Controls.Add(this.pbImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar_Autores";
            this.Text = "Autores Cadastrados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consultar_Autores_FormClosed);
            this.Load += new System.EventHandler(this.Consultar_Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.pnlEditoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.Panel pnlEditoras;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Label label1;
    }
}