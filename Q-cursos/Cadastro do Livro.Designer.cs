
namespace Q_cursos
{
    partial class Cadastro_do_Livro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_do_Livro));
            this.label1 = new System.Windows.Forms.Label();
            this.pbEditora = new System.Windows.Forms.PictureBox();
            this.plEditora = new System.Windows.Forms.Panel();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.textIDdaEditora = new System.Windows.Forms.TextBox();
            this.textIDdoAutor = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.textNomeDoLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditora)).BeginInit();
            this.plEditora.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do Livro";
            // 
            // pbEditora
            // 
            this.pbEditora.Image = ((System.Drawing.Image)(resources.GetObject("pbEditora.Image")));
            this.pbEditora.Location = new System.Drawing.Point(626, 4);
            this.pbEditora.Name = "pbEditora";
            this.pbEditora.Size = new System.Drawing.Size(109, 66);
            this.pbEditora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEditora.TabIndex = 1;
            this.pbEditora.TabStop = false;
            this.pbEditora.Click += new System.EventHandler(this.pbEditora_Click);
            // 
            // plEditora
            // 
            this.plEditora.Controls.Add(this.btnLimpar);
            this.plEditora.Controls.Add(this.btnCadastroLivro);
            this.plEditora.Controls.Add(this.textIDdaEditora);
            this.plEditora.Controls.Add(this.textIDdoAutor);
            this.plEditora.Controls.Add(this.textISBN);
            this.plEditora.Controls.Add(this.textPreco);
            this.plEditora.Controls.Add(this.textNomeDoLivro);
            this.plEditora.Controls.Add(this.label6);
            this.plEditora.Controls.Add(this.label5);
            this.plEditora.Controls.Add(this.label4);
            this.plEditora.Controls.Add(this.label3);
            this.plEditora.Controls.Add(this.label2);
            this.plEditora.Enabled = false;
            this.plEditora.Location = new System.Drawing.Point(12, 77);
            this.plEditora.Name = "plEditora";
            this.plEditora.Size = new System.Drawing.Size(776, 409);
            this.plEditora.TabIndex = 2;
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.BackColor = System.Drawing.Color.Silver;
            this.btnCadastroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivro.Location = new System.Drawing.Point(612, 357);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(149, 34);
            this.btnCadastroLivro.TabIndex = 10;
            this.btnCadastroLivro.Text = "Cadastrar";
            this.btnCadastroLivro.UseVisualStyleBackColor = false;
            this.btnCadastroLivro.Click += new System.EventHandler(this.btnCadastroLivro_Click);
            // 
            // textIDdaEditora
            // 
            this.textIDdaEditora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIDdaEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDdaEditora.Location = new System.Drawing.Point(159, 298);
            this.textIDdaEditora.Name = "textIDdaEditora";
            this.textIDdaEditora.Size = new System.Drawing.Size(602, 19);
            this.textIDdaEditora.TabIndex = 9;
            // 
            // textIDdoAutor
            // 
            this.textIDdoAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIDdoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDdoAutor.Location = new System.Drawing.Point(159, 229);
            this.textIDdoAutor.Name = "textIDdoAutor";
            this.textIDdoAutor.Size = new System.Drawing.Size(602, 19);
            this.textIDdoAutor.TabIndex = 8;
            // 
            // textISBN
            // 
            this.textISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textISBN.Location = new System.Drawing.Point(160, 91);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(601, 19);
            this.textISBN.TabIndex = 7;
            // 
            // textPreco
            // 
            this.textPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPreco.Location = new System.Drawing.Point(159, 160);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(602, 19);
            this.textPreco.TabIndex = 6;
            // 
            // textNomeDoLivro
            // 
            this.textNomeDoLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeDoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeDoLivro.Location = new System.Drawing.Point(166, 23);
            this.textNomeDoLivro.Name = "textNomeDoLivro";
            this.textNomeDoLivro.Size = new System.Drawing.Size(595, 19);
            this.textNomeDoLivro.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID da Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID do Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Livro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(57, 357);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 34);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Cadastro_do_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 498);
            this.Controls.Add(this.plEditora);
            this.Controls.Add(this.pbEditora);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_do_Livro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Livro";
            ((System.ComponentModel.ISupportInitialize)(this.pbEditora)).EndInit();
            this.plEditora.ResumeLayout(false);
            this.plEditora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEditora;
        private System.Windows.Forms.Panel plEditora;
        private System.Windows.Forms.TextBox textIDdaEditora;
        private System.Windows.Forms.TextBox textIDdoAutor;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.TextBox textNomeDoLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btnLimpar;
    }
}