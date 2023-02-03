namespace EjercicioN1
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
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblRespuesta1 = new System.Windows.Forms.Label();
            this.lblRespuesta2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(294, 47);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(73, 61);
            this.btnComprobar.TabIndex = 0;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(70, 68);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(218, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblRespuesta1
            // 
            this.lblRespuesta1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta1.Location = new System.Drawing.Point(12, 113);
            this.lblRespuesta1.Name = "lblRespuesta1";
            this.lblRespuesta1.Size = new System.Drawing.Size(198, 23);
            this.lblRespuesta1.TabIndex = 2;
            // 
            // lblRespuesta2
            // 
            this.lblRespuesta2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta2.Location = new System.Drawing.Point(231, 113);
            this.lblRespuesta2.Name = "lblRespuesta2";
            this.lblRespuesta2.Size = new System.Drawing.Size(193, 23);
            this.lblRespuesta2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 191);
            this.Controls.Add(this.lblRespuesta2);
            this.Controls.Add(this.lblRespuesta1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnComprobar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblRespuesta1;
        private System.Windows.Forms.Label lblRespuesta2;
    }
}

