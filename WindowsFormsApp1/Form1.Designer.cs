namespace WindowsFormsApp1
{
    partial class formLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxuser = new System.Windows.Forms.PictureBox();
            this.labelacessar = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBox2senha = new System.Windows.Forms.TextBox();
            this.buttonadicionar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxuser
            // 
            this.pictureBoxuser.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBoxuser.Location = new System.Drawing.Point(18, 46);
            this.pictureBoxuser.Name = "pictureBoxuser";
            this.pictureBoxuser.Size = new System.Drawing.Size(143, 177);
            this.pictureBoxuser.TabIndex = 0;
            this.pictureBoxuser.TabStop = false;
            this.pictureBoxuser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelacessar
            // 
            this.labelacessar.AutoSize = true;
            this.labelacessar.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelacessar.Location = new System.Drawing.Point(39, 9);
            this.labelacessar.Name = "labelacessar";
            this.labelacessar.Size = new System.Drawing.Size(105, 34);
            this.labelacessar.TabIndex = 1;
            this.labelacessar.Text = "Acessar";
            this.labelacessar.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(12, 226);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(116, 34);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuário:";
            this.labeluser.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.Location = new System.Drawing.Point(12, 274);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(98, 34);
            this.labelsenha.TabIndex = 3;
            this.labelsenha.Text = "Senha:";
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(134, 239);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(218, 20);
            this.textBoxusuario.TabIndex = 4;
            // 
            // textBox2senha
            // 
            this.textBox2senha.Location = new System.Drawing.Point(134, 287);
            this.textBox2senha.Name = "textBox2senha";
            this.textBox2senha.PasswordChar = '*';
            this.textBox2senha.Size = new System.Drawing.Size(218, 20);
            this.textBox2senha.TabIndex = 5;
            this.textBox2senha.UseSystemPasswordChar = true;
            // 
            // buttonadicionar
            // 
            this.buttonadicionar.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadicionar.Location = new System.Drawing.Point(12, 323);
            this.buttonadicionar.Name = "buttonadicionar";
            this.buttonadicionar.Size = new System.Drawing.Size(169, 89);
            this.buttonadicionar.TabIndex = 7;
            this.buttonadicionar.Text = "Adicionar";
            this.buttonadicionar.UseVisualStyleBackColor = true;
            this.buttonadicionar.Click += new System.EventHandler(this.buttonadicionar_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancelar.Location = new System.Drawing.Point(183, 323);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(169, 89);
            this.buttoncancelar.TabIndex = 8;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(362, 424);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonadicionar);
            this.Controls.Add(this.textBox2senha);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labelacessar);
            this.Controls.Add(this.pictureBoxuser);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxuser;
        private System.Windows.Forms.Label labelacessar;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBox2senha;
        private System.Windows.Forms.Button buttonadicionar;
        private System.Windows.Forms.Button buttoncancelar;
    }
}

