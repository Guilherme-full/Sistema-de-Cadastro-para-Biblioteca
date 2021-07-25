
namespace Q_cursos
{
    partial class Livros_Cadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livros_Cadastrados));
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagemLi = new System.Windows.Forms.PictureBox();
            this.pnlLivros = new System.Windows.Forms.Panel();
            this.Exibir = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLi)).BeginInit();
            this.pnlLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(334, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Livros Cadastrados";
            // 
            // pbImagemLi
            // 
            this.pbImagemLi.BackColor = System.Drawing.Color.Silver;
            this.pbImagemLi.Image = ((System.Drawing.Image)(resources.GetObject("pbImagemLi.Image")));
            this.pbImagemLi.Location = new System.Drawing.Point(822, 12);
            this.pbImagemLi.Name = "pbImagemLi";
            this.pbImagemLi.Size = new System.Drawing.Size(113, 61);
            this.pbImagemLi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemLi.TabIndex = 6;
            this.pbImagemLi.TabStop = false;
            this.pbImagemLi.Click += new System.EventHandler(this.pbImagemLi_Click);
            // 
            // pnlLivros
            // 
            this.pnlLivros.Controls.Add(this.Exibir);
            this.pnlLivros.Controls.Add(this.dgvLivros);
            this.pnlLivros.Enabled = false;
            this.pnlLivros.Location = new System.Drawing.Point(37, 79);
            this.pnlLivros.Name = "pnlLivros";
            this.pnlLivros.Size = new System.Drawing.Size(1013, 583);
            this.pnlLivros.TabIndex = 8;
            // 
            // Exibir
            // 
            this.Exibir.BackColor = System.Drawing.Color.Silver;
            this.Exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir.Location = new System.Drawing.Point(3, 33);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(101, 33);
            this.Exibir.TabIndex = 3;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = false;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(3, 72);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(999, 471);
            this.dgvLivros.TabIndex = 0;
            // 
            // Livros_Cadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1196, 709);
            this.Controls.Add(this.pnlLivros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagemLi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Livros_Cadastrados";
            this.Text = "Livros Cadastrados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Livros_Cadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLi)).EndInit();
            this.pnlLivros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagemLi;
        private System.Windows.Forms.Panel pnlLivros;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.DataGridView dgvLivros;
    }
}