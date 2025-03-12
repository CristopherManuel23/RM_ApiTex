namespace RM_APItex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dgvCharacters = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Especie = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 344);
            button1.Name = "button1";
            button1.Size = new Size(198, 58);
            button1.TabIndex = 0;
            button1.Text = "Obtener Personaje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // dgvCharacters
            // 
            dgvCharacters.AllowUserToAddRows = false;
            dgvCharacters.AllowUserToDeleteRows = false;
            dgvCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCharacters.Columns.AddRange(new DataGridViewColumn[] { Nombre, Especie, Genero, Origen });
            dgvCharacters.Location = new Point(12, 12);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.ReadOnly = true;
            dgvCharacters.RowHeadersWidth = 62;
            dgvCharacters.Size = new Size(776, 252);
            dgvCharacters.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Especie
            // 
            Especie.HeaderText = "Especie";
            Especie.MinimumWidth = 8;
            Especie.Name = "Especie";
            Especie.ReadOnly = true;
            Especie.Width = 150;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 8;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 150;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 8;
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCharacters);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvCharacters;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Origen;
    }
}
