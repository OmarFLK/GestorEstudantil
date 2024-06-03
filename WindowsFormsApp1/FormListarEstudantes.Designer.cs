namespace WindowsFormsApp1
{
    partial class FormListarEstudantes
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
            this.dataGridViewListadeAlunos = new System.Windows.Forms.DataGridView();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadeAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListadeAlunos
            // 
            this.dataGridViewListadeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadeAlunos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListadeAlunos.Name = "dataGridViewListadeAlunos";
            this.dataGridViewListadeAlunos.Size = new System.Drawing.Size(776, 331);
            this.dataGridViewListadeAlunos.TabIndex = 0;
            this.dataGridViewListadeAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadeAlunos_CellContentClick);
            this.dataGridViewListadeAlunos.DoubleClick += new System.EventHandler(this.dataGridViewListadeAlunos_DoubleClick);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(12, 349);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(776, 89);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormListarEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridViewListadeAlunos);
            this.Name = "FormListarEstudantes";
            this.Text = "FormListarEstudantes";
            this.Load += new System.EventHandler(this.FormListarEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadeAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadeAlunos;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}