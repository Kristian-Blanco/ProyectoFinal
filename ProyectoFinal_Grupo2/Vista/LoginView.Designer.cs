
namespace ProyectoFinal_Grupo2.Vista
{
    partial class LoginView
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
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.ContraseniatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(438, 91);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(313, 26);
            this.EmailTextbox.TabIndex = 0;
            this.EmailTextbox.Text = "estefany@gmail.com";
            // 
            // ContraseniatextBox
            // 
            this.ContraseniatextBox.Location = new System.Drawing.Point(438, 158);
            this.ContraseniatextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContraseniatextBox.Name = "ContraseniatextBox";
            this.ContraseniatextBox.PasswordChar = '*';
            this.ContraseniatextBox.Size = new System.Drawing.Size(313, 26);
            this.ContraseniatextBox.TabIndex = 1;
            this.ContraseniatextBox.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(546, 215);
            this.Aceptarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(98, 51);
            this.Aceptarbutton.TabIndex = 5;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(660, 215);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(93, 51);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_Grupo2.Properties.Resources.programador;
            this.pictureBox1.Location = new System.Drawing.Point(65, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContraseniatextBox);
            this.Controls.Add(this.EmailTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginView";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox EmailTextbox;
        public System.Windows.Forms.TextBox ContraseniatextBox;
        public System.Windows.Forms.Button Aceptarbutton;
        public System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}