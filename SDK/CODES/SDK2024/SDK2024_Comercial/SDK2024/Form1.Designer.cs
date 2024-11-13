
namespace SDK2024
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
            this.btnAbreEmpresa = new System.Windows.Forms.Button();
            this.btnInicia = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.btnCierraEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbreEmpresa
            // 
            this.btnAbreEmpresa.Location = new System.Drawing.Point(9, 121);
            this.btnAbreEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbreEmpresa.Name = "btnAbreEmpresa";
            this.btnAbreEmpresa.Size = new System.Drawing.Size(110, 25);
            this.btnAbreEmpresa.TabIndex = 43;
            this.btnAbreEmpresa.Text = "Abre Empresa";
            this.btnAbreEmpresa.UseVisualStyleBackColor = true;
            this.btnAbreEmpresa.Click += new System.EventHandler(this.btnAbreEmpresa_Click);
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(9, 13);
            this.btnInicia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(97, 24);
            this.btnInicia.TabIndex = 42;
            this.btnInicia.Text = "Inicia Sesion";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Location = new System.Drawing.Point(172, 13);
            this.btnTermina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(111, 24);
            this.btnTermina.TabIndex = 45;
            this.btnTermina.Text = "Termina Sesion";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnCierraEmpresa
            // 
            this.btnCierraEmpresa.Location = new System.Drawing.Point(176, 121);
            this.btnCierraEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCierraEmpresa.Name = "btnCierraEmpresa";
            this.btnCierraEmpresa.Size = new System.Drawing.Size(107, 25);
            this.btnCierraEmpresa.TabIndex = 46;
            this.btnCierraEmpresa.Text = "Cierra Empresa";
            this.btnCierraEmpresa.UseVisualStyleBackColor = true;
            this.btnCierraEmpresa.Click += new System.EventHandler(this.btnCierraEmpresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 155);
            this.Controls.Add(this.btnCierraEmpresa);
            this.Controls.Add(this.btnTermina);
            this.Controls.Add(this.btnAbreEmpresa);
            this.Controls.Add(this.btnInicia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbreEmpresa;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.Button btnCierraEmpresa;
    }
}

