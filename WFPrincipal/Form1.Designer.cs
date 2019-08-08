namespace WFPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(783, 351);
            this.panel1.TabIndex = 0;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pMenu.Controls.Add(this.btnGraficas);
            this.pMenu.Controls.Add(this.btnRecetas);
            this.pMenu.Controls.Add(this.btnMenu);
            this.pMenu.Controls.Add(this.btnProductos);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.MinimumSize = new System.Drawing.Size(150, 300);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(150, 351);
            this.pMenu.TabIndex = 1;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(12, 70);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(126, 43);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 119);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(126, 43);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(12, 168);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(126, 43);
            this.btnRecetas.TabIndex = 2;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            // 
            // btnGraficas
            // 
            this.btnGraficas.Location = new System.Drawing.Point(12, 217);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(126, 43);
            this.btnGraficas.TabIndex = 3;
            this.btnGraficas.Text = "Gráficas";
            this.btnGraficas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 351);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnProductos;
    }
}

