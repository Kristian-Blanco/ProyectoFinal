
namespace ProyectoFinal_Grupo2.Vista
{
    partial class BuscarClienteView
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
            this.NombreClientelabel = new System.Windows.Forms.Label();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreClientelabel
            // 
            this.NombreClientelabel.AutoSize = true;
            this.NombreClientelabel.Location = new System.Drawing.Point(137, 90);
            this.NombreClientelabel.Name = "NombreClientelabel";
            this.NombreClientelabel.Size = new System.Drawing.Size(82, 13);
            this.NombreClientelabel.TabIndex = 0;
            this.NombreClientelabel.Text = "Nombre Cliente:";
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Location = new System.Drawing.Point(312, 90);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreClientetextBox.TabIndex = 1;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(156, 171);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar ";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(351, 171);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 3;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 125);
            this.dataGridView1.TabIndex = 4;
            
            // 
            // BuscarClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 337);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.NombreClientetextBox);
            this.Controls.Add(this.NombreClientelabel);
            this.Name = "BuscarClienteView";
            this.Text = "BuscarClienteView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreClientelabel;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}