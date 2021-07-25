
namespace Q_cursos
{
    partial class Geral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geral));
            this.label1 = new System.Windows.Forms.Label();
            this.pbGeral = new System.Windows.Forms.PictureBox();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.Exibir = new System.Windows.Forms.Button();
            this.dgvGeral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeral)).BeginInit();
            this.pnlGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(367, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relação Geral";
            // 
            // pbGeral
            // 
            this.pbGeral.BackColor = System.Drawing.Color.Silver;
            this.pbGeral.Image = ((System.Drawing.Image)(resources.GetObject("pbGeral.Image")));
            this.pbGeral.Location = new System.Drawing.Point(855, 12);
            this.pbGeral.Name = "pbGeral";
            this.pbGeral.Size = new System.Drawing.Size(113, 61);
            this.pbGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGeral.TabIndex = 10;
            this.pbGeral.TabStop = false;
            this.pbGeral.Click += new System.EventHandler(this.pbGeral_Click);
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.Exibir);
            this.pnlGeral.Controls.Add(this.dgvGeral);
            this.pnlGeral.Enabled = false;
            this.pnlGeral.Location = new System.Drawing.Point(49, 93);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(1109, 556);
            this.pnlGeral.TabIndex = 12;
            // 
            // Exibir
            // 
            this.Exibir.BackColor = System.Drawing.Color.Silver;
            this.Exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir.Location = new System.Drawing.Point(3, 17);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(101, 33);
            this.Exibir.TabIndex = 4;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = false;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // dgvGeral
            // 
            this.dgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeral.Location = new System.Drawing.Point(3, 55);
            this.dgvGeral.Name = "dgvGeral";
            this.dgvGeral.Size = new System.Drawing.Size(1103, 498);
            this.dgvGeral.TabIndex = 0;
            // 
            // Geral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1237, 671);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.pbGeral);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Geral";
            this.Text = "Geral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Geral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGeral)).EndInit();
            this.pnlGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGeral;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.DataGridView dgvGeral;
    }
}