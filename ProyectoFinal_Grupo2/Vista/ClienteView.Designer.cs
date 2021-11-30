
namespace ProyectoFinal_Grupo2.Vista
{
    partial class ClienteView
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
            this.components = new System.ComponentModel.Container();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ImagenButton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentidadMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 391);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.RowHeadersWidth = 51;
            this.ClientesDataGridView.RowTemplate.Height = 24;
            this.ClientesDataGridView.Size = new System.Drawing.Size(805, 256);
            this.ClientesDataGridView.TabIndex = 38;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(592, 330);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(99, 37);
            this.CancelarButton.TabIndex = 37;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(478, 330);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(99, 37);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(358, 330);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(99, 37);
            this.GuardarButton.TabIndex = 35;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(243, 330);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(99, 37);
            this.ModificarButton.TabIndex = 34;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(120, 330);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(99, 37);
            this.NuevoButton.TabIndex = 33;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ImagenButton
            // 
            this.ImagenButton.Enabled = false;
            this.ImagenButton.Location = new System.Drawing.Point(510, 249);
            this.ImagenButton.Name = "ImagenButton";
            this.ImagenButton.Size = new System.Drawing.Size(85, 33);
            this.ImagenButton.TabIndex = 32;
            this.ImagenButton.Text = "Imagen...";
            this.ImagenButton.UseVisualStyleBackColor = true;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.Color.White;
            this.ImagenPictureBox.Location = new System.Drawing.Point(510, 26);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(224, 217);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 31;
            this.ImagenPictureBox.TabStop = false;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(169, 232);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(273, 22);
            this.DireccionTextBox.TabIndex = 30;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(169, 181);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(273, 22);
            this.EmailTextBox.TabIndex = 29;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(169, 131);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(273, 22);
            this.NombreTextBox.TabIndex = 28;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(169, 26);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Identidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id";
            // 
            // IdentidadMaskedTextBox
            // 
            this.IdentidadMaskedTextBox.Location = new System.Drawing.Point(169, 79);
            this.IdentidadMaskedTextBox.Mask = "####-####-#####";
            this.IdentidadMaskedTextBox.Name = "IdentidadMaskedTextBox";
            this.IdentidadMaskedTextBox.Size = new System.Drawing.Size(273, 22);
            this.IdentidadMaskedTextBox.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 648);
            this.Controls.Add(this.IdentidadMaskedTextBox);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ImagenButton);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteView";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ClientesDataGridView;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.Button ImagenButton;
        public System.Windows.Forms.PictureBox ImagenPictureBox;
        public System.Windows.Forms.TextBox DireccionTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox IdentidadMaskedTextBox;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}