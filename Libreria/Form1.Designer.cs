namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.listUsuarios = new System.Windows.Forms.ListView();
            this.headerNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLibros = new System.Windows.Forms.ListView();
            this.headerTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ImprimirMorosos = new System.Drawing.Printing.PrintDocument();
            this.VistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.nuevoLibroToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // nuevoLibroToolStripMenuItem
            // 
            this.nuevoLibroToolStripMenuItem.Name = "nuevoLibroToolStripMenuItem";
            this.nuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoLibroToolStripMenuItem.Text = "Nuevo Libro";
            this.nuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.nuevoLibroToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem1,
            this.exportarToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.imprimirMorososToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.importarToolStripMenuItem.Text = "Herramientas";
            // 
            // importarToolStripMenuItem1
            // 
            this.importarToolStripMenuItem1.Name = "importarToolStripMenuItem1";
            this.importarToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.importarToolStripMenuItem1.Text = "Importar";
            this.importarToolStripMenuItem1.Click += new System.EventHandler(this.importarToolStripMenuItem1_Click);
            // 
            // exportarToolStripMenuItem1
            // 
            this.exportarToolStripMenuItem1.Name = "exportarToolStripMenuItem1";
            this.exportarToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.exportarToolStripMenuItem1.Text = "Exportar";
            this.exportarToolStripMenuItem1.Click += new System.EventHandler(this.exportarToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem1,
            this.cargarToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.guardarToolStripMenuItem.Text = "Backup";
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // imprimirMorososToolStripMenuItem
            // 
            this.imprimirMorososToolStripMenuItem.Name = "imprimirMorososToolStripMenuItem";
            this.imprimirMorososToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.imprimirMorososToolStripMenuItem.Text = "Imprimir Morosos";
            this.imprimirMorososToolStripMenuItem.Click += new System.EventHandler(this.imprimirMorososToolStripMenuItem_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(47, 38);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(117, 20);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // listUsuarios
            // 
            this.listUsuarios.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNombre,
            this.headerDNI});
            this.listUsuarios.FullRowSelect = true;
            this.listUsuarios.GridLines = true;
            this.listUsuarios.Location = new System.Drawing.Point(12, 77);
            this.listUsuarios.MultiSelect = false;
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(280, 308);
            this.listUsuarios.TabIndex = 5;
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.View = System.Windows.Forms.View.Details;
            this.listUsuarios.ItemActivate += new System.EventHandler(this.listUsuarios_ItemActivate);
            // 
            // headerNombre
            // 
            this.headerNombre.Text = "Nombre";
            this.headerNombre.Width = 200;
            // 
            // headerDNI
            // 
            this.headerDNI.Text = "DNI";
            this.headerDNI.Width = 76;
            // 
            // listLibros
            // 
            this.listLibros.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerTitulo,
            this.headerISBN});
            this.listLibros.FullRowSelect = true;
            this.listLibros.GridLines = true;
            this.listLibros.Location = new System.Drawing.Point(298, 77);
            this.listLibros.MultiSelect = false;
            this.listLibros.Name = "listLibros";
            this.listLibros.Size = new System.Drawing.Size(280, 308);
            this.listLibros.TabIndex = 6;
            this.listLibros.UseCompatibleStateImageBehavior = false;
            this.listLibros.View = System.Windows.Forms.View.Details;
            this.listLibros.ItemActivate += new System.EventHandler(this.listLibros_ItemActivate);
            // 
            // headerTitulo
            // 
            this.headerTitulo.Text = "Título";
            this.headerTitulo.Width = 179;
            // 
            // headerISBN
            // 
            this.headerISBN.Text = "ISBN";
            this.headerISBN.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(339, 38);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(117, 20);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // ImprimirMorosos
            // 
            this.ImprimirMorosos.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.ImprimirMorosos_BeginPrint);
            this.ImprimirMorosos.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.ImprimirMorosos_EndPrint);
            this.ImprimirMorosos.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirMorosos_PrintPage);
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.VistaPrevia.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.VistaPrevia.ClientSize = new System.Drawing.Size(400, 300);
            this.VistaPrevia.Enabled = true;
            this.VistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("VistaPrevia.Icon")));
            this.VistaPrevia.Name = "printPreviewDialog1";
            this.VistaPrevia.Visible = false;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listLibros);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirMorososToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ListView listUsuarios;
        private System.Windows.Forms.ColumnHeader headerNombre;
        private System.Windows.Forms.ColumnHeader headerDNI;
        private System.Windows.Forms.ListView listLibros;
        private System.Windows.Forms.ColumnHeader headerTitulo;
        private System.Windows.Forms.ColumnHeader headerISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument ImprimirMorosos;
        private System.Windows.Forms.PrintPreviewDialog VistaPrevia;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;



    }
}

