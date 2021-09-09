
namespace Q_cursos
{
    partial class Cadastro_de_Autor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Autor));
            this.label1 = new System.Windows.Forms.Label();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.pnCad = new System.Windows.Forms.Panel();
            this.btnCadastroAutor = new System.Windows.Forms.Button();
            this.textEstadoAutor = new System.Windows.Forms.TextBox();
            this.textEmailAutor = new System.Windows.Forms.TextBox();
            this.textCidadeAutor = new System.Windows.Forms.TextBox();
            this.textNomeCompletoAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            this.pnCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Autor";
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.BackColor = System.Drawing.Color.Silver;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(601, 12);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(85, 54);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdicionar.TabIndex = 1;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.pbAdicionar_Click);
            // 
            // pnCad
            // 
            this.pnCad.Controls.Add(this.btnLimpar);
            this.pnCad.Controls.Add(this.btnCadastroAutor);
            this.pnCad.Controls.Add(this.textEstadoAutor);
            this.pnCad.Controls.Add(this.textEmailAutor);
            this.pnCad.Controls.Add(this.textCidadeAutor);
            this.pnCad.Controls.Add(this.textNomeCompletoAutor);
            this.pnCad.Controls.Add(this.label4);
            this.pnCad.Controls.Add(this.label3);
            this.pnCad.Controls.Add(this.label5);
            this.pnCad.Controls.Add(this.label2);
            this.pnCad.Enabled = false;
            this.pnCad.Location = new System.Drawing.Point(12, 89);
            this.pnCad.Name = "pnCad";
            this.pnCad.Size = new System.Drawing.Size(776, 384);
            this.pnCad.TabIndex = 2;
            // 
            // btnCadastroAutor
            // 
            this.btnCadastroAutor.BackColor = System.Drawing.Color.Silver;
            this.btnCadastroAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAutor.Location = new System.Drawing.Point(612, 320);
            this.btnCadastroAutor.Name = "btnCadastroAutor";
            this.btnCadastroAutor.Size = new System.Drawing.Size(119, 35);
            this.btnCadastroAutor.TabIndex = 10;
            this.btnCadastroAutor.Text = "Cadastrar";
            this.btnCadastroAutor.UseVisualStyleBackColor = false;
            this.btnCadastroAutor.Click += new System.EventHandler(this.btnCadastroAutor_Click);
            // 
            // textEstadoAutor
            // 
            this.textEstadoAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEstadoAutor.Font = new System.Drawing.Font("Arial", 13F);
            this.textEstadoAutor.Location = new System.Drawing.Point(161, 100);
            this.textEstadoAutor.Multiline = true;
            this.textEstadoAutor.Name = "textEstadoAutor";
            this.textEstadoAutor.Size = new System.Drawing.Size(572, 26);
            this.textEstadoAutor.TabIndex = 9;
            // 
            // textEmailAutor
            // 
            this.textEmailAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailAutor.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailAutor.Location = new System.Drawing.Point(159, 242);
            this.textEmailAutor.Multiline = true;
            this.textEmailAutor.Name = "textEmailAutor";
            this.textEmailAutor.Size = new System.Drawing.Size(572, 26);
            this.textEmailAutor.TabIndex = 8;
            // 
            // textCidadeAutor
            // 
            this.textCidadeAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCidadeAutor.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCidadeAutor.Location = new System.Drawing.Point(160, 168);
            this.textCidadeAutor.Multiline = true;
            this.textCidadeAutor.Name = "textCidadeAutor";
            this.textCidadeAutor.Size = new System.Drawing.Size(572, 25);
            this.textCidadeAutor.TabIndex = 7;
            // 
            // textNomeCompletoAutor
            // 
            this.textNomeCompletoAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeCompletoAutor.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCompletoAutor.Location = new System.Drawing.Point(161, 25);
            this.textNomeCompletoAutor.Multiline = true;
            this.textNomeCompletoAutor.Name = "textNomeCompletoAutor";
            this.textNomeCompletoAutor.Size = new System.Drawing.Size(572, 24);
            this.textNomeCompletoAutor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(102, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(92, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(118, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Cadastro_de_Autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.pnCad);
            this.Controls.Add(this.pbAdicionar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_de_Autor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Autor";
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            this.pnCad.ResumeLayout(false);
            this.pnCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.Panel pnCad;
        private System.Windows.Forms.TextBox textEstadoAutor;
        private System.Windows.Forms.TextBox textEmailAutor;
        private System.Windows.Forms.TextBox textCidadeAutor;
        private System.Windows.Forms.TextBox textNomeCompletoAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroAutor;
        private System.Windows.Forms.Button btnLimpar;
    }
}