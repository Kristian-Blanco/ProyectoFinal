
namespace ProyectoFinal_Grupo2.Vista
{
    partial class ProductoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoProductoComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductoPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(127, 81);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(170, 20);
            this.CodigoProductoTextBox.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(127, 117);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(170, 20);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(127, 154);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(170, 20);
            this.ExistenciaTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(127, 195);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(170, 20);
            this.PrecioTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Producto";
            // 
            // TipoProductoComboBox
            // 
            this.TipoProductoComboBox.FormattingEnabled = true;
            this.TipoProductoComboBox.Location = new System.Drawing.Point(127, 235);
            this.TipoProductoComboBox.Name = "TipoProductoComboBox";
            this.TipoProductoComboBox.Size = new System.Drawing.Size(170, 21);
            this.TipoProductoComboBox.TabIndex = 11;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(578, 227);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(102, 35);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar Imagen...";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 137);
            this.dataGridView1.TabIndex = 14;
            // 
            // ProductoPictureBox
            // 
            this.ProductoPictureBox.Location = new System.Drawing.Point(432, 48);
            this.ProductoPictureBox.Name = "ProductoPictureBox";
            this.ProductoPictureBox.Size = new System.Drawing.Size(248, 167);
            this.ProductoPictureBox.TabIndex = 12;
            this.ProductoPictureBox.TabStop = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(403, 295);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(74, 30);
            this.CancelarButton.TabIndex = 47;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(317, 295);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 30);
            this.EliminarButton.TabIndex = 46;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(227, 295);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(74, 30);
            this.GuardarButton.TabIndex = 45;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(141, 295);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(74, 30);
            this.ModificarButton.TabIndex = 44;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(49, 295);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(74, 30);
            this.NuevoButton.TabIndex = 43;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ProductoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 494);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ProductoPictureBox);
            this.Controls.Add(this.TipoProductoComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigoProductoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ProductoView";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TipoProductoComboBox;
        private System.Windows.Forms.PictureBox ProductoPictureBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
    }
}