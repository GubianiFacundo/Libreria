namespace WindowsFormsApplication1
{
    partial class FUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.labEstado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grillaPrestamos = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBanear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ImprimirPrestamos = new System.Drawing.Printing.PrintDocument();
            this.previewPrestamos = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(59, 34);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(10, 13);
            this.labNom.TabIndex = 4;
            this.labNom.Text = "-";
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Location = new System.Drawing.Point(59, 74);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(10, 13);
            this.labDNI.TabIndex = 5;
            this.labDNI.Text = "-";
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(59, 114);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(10, 13);
            this.labMail.TabIndex = 6;
            this.labMail.Text = "-";
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Location = new System.Drawing.Point(59, 154);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(10, 13);
            this.labEstado.TabIndex = 7;
            this.labEstado.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.labMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labDNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(183, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(35, 31);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grillaPrestamos
            // 
            this.grillaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPrestamos.Location = new System.Drawing.Point(236, 12);
            this.grillaPrestamos.MultiSelect = false;
            this.grillaPrestamos.Name = "grillaPrestamos";
            this.grillaPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaPrestamos.Size = new System.Drawing.Size(562, 205);
            this.grillaPrestamos.TabIndex = 9;
            this.grillaPrestamos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPrestamos_CellDoubleClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(279, 242);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBanear
            // 
            this.btnBanear.Location = new System.Drawing.Point(368, 242);
            this.btnBanear.Name = "btnBanear";
            this.btnBanear.Size = new System.Drawing.Size(75, 23);
            this.btnBanear.TabIndex = 13;
            this.btnBanear.Text = "Deshabilitar";
            this.btnBanear.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(457, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.ImprimirPrestamos;
            // 
            // ImprimirPrestamos
            // 
            this.ImprimirPrestamos.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.ImprimirPrestamos_BeginPrint);
            this.ImprimirPrestamos.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.ImprimirPrestamos_EndPrint);
            this.ImprimirPrestamos.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirPrestamos_PrintPage);
            // 
            // previewPrestamos
            // 
            this.previewPrestamos.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewPrestamos.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewPrestamos.ClientSize = new System.Drawing.Size(400, 300);
            this.previewPrestamos.Document = this.ImprimirPrestamos;
            this.previewPrestamos.Enabled = true;
            this.previewPrestamos.Icon = ((System.Drawing.Icon)(resources.GetObject("previewPrestamos.Icon")));
            this.previewPrestamos.Name = "previewPrestamos";
            this.previewPrestamos.Visible = false;
            // 
            // FUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 288);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBanear);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grillaPrestamos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaPrestamos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBanear;
        public System.Windows.Forms.Label labNom;
        public System.Windows.Forms.Label labDNI;
        public System.Windows.Forms.Label labMail;
        public System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument ImprimirPrestamos;
        private System.Windows.Forms.PrintPreviewDialog previewPrestamos;
    }
}