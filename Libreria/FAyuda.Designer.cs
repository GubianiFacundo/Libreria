namespace WindowsFormsApplication1
{
    partial class FAyuda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.wBAyuda = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wBAyuda
            // 
            this.wBAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBAyuda.Location = new System.Drawing.Point(0, 0);
            this.wBAyuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBAyuda.Name = "wBAyuda";
            this.wBAyuda.Size = new System.Drawing.Size(284, 261);
            this.wBAyuda.TabIndex = 0;
            // 
            // FAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.wBAyuda);
            this.Name = "FAyuda";
            this.Text = "FAyuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wBAyuda;

    }
}