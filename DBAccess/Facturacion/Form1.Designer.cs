namespace Facturacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewClientButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Label();
            this.CantidadComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.BuscarLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewClientButton
            // 
            this.NewClientButton.Location = new System.Drawing.Point(330, 80);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Size = new System.Drawing.Size(114, 23);
            this.NewClientButton.TabIndex = 0;
            this.NewClientButton.Text = "Agregar Cliente";
            this.NewClientButton.UseVisualStyleBackColor = true;
            // 
            // ShowButton
            // 
            this.ShowButton.AutoSize = true;
            this.ShowButton.Location = new System.Drawing.Point(39, 175);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(45, 13);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Mostrar:";
            // 
            // CantidadComboBox
            // 
            this.CantidadComboBox.FormattingEnabled = true;
            this.CantidadComboBox.Location = new System.Drawing.Point(90, 172);
            this.CantidadComboBox.Name = "CantidadComboBox";
            this.CantidadComboBox.Size = new System.Drawing.Size(56, 21);
            this.CantidadComboBox.TabIndex = 2;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(152, 175);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(46, 13);
            this.RegisterLabel.TabIndex = 3;
            this.RegisterLabel.Text = "registros";
            // 
            // BuscarLabel
            // 
            this.BuscarLabel.AutoSize = true;
            this.BuscarLabel.Location = new System.Drawing.Point(596, 175);
            this.BuscarLabel.Name = "BuscarLabel";
            this.BuscarLabel.Size = new System.Drawing.Size(40, 13);
            this.BuscarLabel.TabIndex = 4;
            this.BuscarLabel.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 224);
            this.dataGridView1.TabIndex = 5;
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(642, 172);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(117, 20);
            this.BuscarTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuscarLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.CantidadComboBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.NewClientButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewClientButton;
        private System.Windows.Forms.Label ShowButton;
        private System.Windows.Forms.ComboBox CantidadComboBox;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label BuscarLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BuscarTextBox;
    }
}

