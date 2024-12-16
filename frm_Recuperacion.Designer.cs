namespace Taller_1._3_Grupo_1
{
    partial class frm_Recuperacion
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
            this.txt_Animal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AceptarR = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UsuarioR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Animal
            // 
            this.txt_Animal.Location = new System.Drawing.Point(73, 217);
            this.txt_Animal.Name = "txt_Animal";
            this.txt_Animal.Size = new System.Drawing.Size(183, 20);
            this.txt_Animal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Cuál es su animal favorito?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recuperación de Contraseña";
            // 
            // btn_AceptarR
            // 
            this.btn_AceptarR.Location = new System.Drawing.Point(82, 254);
            this.btn_AceptarR.Name = "btn_AceptarR";
            this.btn_AceptarR.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarR.TabIndex = 3;
            this.btn_AceptarR.Text = "Aceptar";
            this.btn_AceptarR.UseVisualStyleBackColor = true;
            this.btn_AceptarR.Click += new System.EventHandler(this.btn_AceptarR_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(181, 254);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 4;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese su Usuario";
            // 
            // txt_UsuarioR
            // 
            this.txt_UsuarioR.Location = new System.Drawing.Point(73, 128);
            this.txt_UsuarioR.Name = "txt_UsuarioR";
            this.txt_UsuarioR.Size = new System.Drawing.Size(183, 20);
            this.txt_UsuarioR.TabIndex = 6;
            // 
            // frm_Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 285);
            this.Controls.Add(this.txt_UsuarioR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_AceptarR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Animal);
            this.Name = "frm_Recuperacion";
            this.Text = "frm_Recuperacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AceptarR;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UsuarioR;
    }
}