namespace WindowsFormsApplication1
{
    partial class FPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labEstado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labAutores = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nroPrest = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBusqEjemplar = new System.Windows.Forms.TextBox();
            this.txtBusqUser = new System.Windows.Forms.TextBox();
            this.btnBusqEjemplar = new System.Windows.Forms.Button();
            this.lbDni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroPrest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labDNI);
            this.groupBox1.Controls.Add(this.labNom);
            this.groupBox1.Location = new System.Drawing.Point(35, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
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
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(59, 114);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(10, 13);
            this.labMail.TabIndex = 6;
            this.labMail.Text = "-";
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
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Location = new System.Drawing.Point(59, 74);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(10, 13);
            this.labDNI.TabIndex = 5;
            this.labDNI.Text = "-";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labEstado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labAutores);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labCodigo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labTitulo);
            this.groupBox2.Location = new System.Drawing.Point(238, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 205);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Título:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código:";
            // 
            // labAutores
            // 
            this.labAutores.AutoSize = true;
            this.labAutores.Location = new System.Drawing.Point(59, 114);
            this.labAutores.Name = "labAutores";
            this.labAutores.Size = new System.Drawing.Size(10, 13);
            this.labAutores.TabIndex = 6;
            this.labAutores.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Autores:";
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(59, 74);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(10, 13);
            this.labCodigo.TabIndex = 5;
            this.labCodigo.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Estado:";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(59, 34);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(10, 13);
            this.labTitulo.TabIndex = 4;
            this.labTitulo.Text = "-";
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarUser.BackgroundImage")));
            this.btnBuscarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUser.Location = new System.Drawing.Point(187, 17);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(38, 31);
            this.btnBuscarUser.TabIndex = 3;
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerar.Location = new System.Drawing.Point(133, 306);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nroPrest
            // 
            this.nroPrest.Location = new System.Drawing.Point(238, 270);
            this.nroPrest.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nroPrest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nroPrest.Name = "nroPrest";
            this.nroPrest.Size = new System.Drawing.Size(44, 20);
            this.nroPrest.TabIndex = 5;
            this.nroPrest.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Nro. de días:";
            // 
            // txtBusqEjemplar
            // 
            this.txtBusqEjemplar.Location = new System.Drawing.Point(281, 23);
            this.txtBusqEjemplar.Name = "txtBusqEjemplar";
            this.txtBusqEjemplar.Size = new System.Drawing.Size(114, 20);
            this.txtBusqEjemplar.TabIndex = 2;
            this.txtBusqEjemplar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqEjemplar_KeyPress);
            // 
            // txtBusqUser
            // 
            this.txtBusqUser.Location = new System.Drawing.Point(67, 23);
            this.txtBusqUser.MaxLength = 8;
            this.txtBusqUser.Name = "txtBusqUser";
            this.txtBusqUser.Size = new System.Drawing.Size(114, 20);
            this.txtBusqUser.TabIndex = 1;
            this.txtBusqUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqUser_KeyPress);
            // 
            // btnBusqEjemplar
            // 
            this.btnBusqEjemplar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusqEjemplar.BackgroundImage")));
            this.btnBusqEjemplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusqEjemplar.Location = new System.Drawing.Point(401, 17);
            this.btnBusqEjemplar.Name = "btnBusqEjemplar";
            this.btnBusqEjemplar.Size = new System.Drawing.Size(38, 31);
            this.btnBusqEjemplar.TabIndex = 4;
            this.btnBusqEjemplar.UseVisualStyleBackColor = true;
            this.btnBusqEjemplar.Click += new System.EventHandler(this.btnBusqEjemplar_Click);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(32, 26);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(29, 13);
            this.lbDni.TabIndex = 18;
            this.lbDni.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Código:";
            // 
            // FPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nroPrest);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBusqEjemplar);
            this.Controls.Add(this.txtBusqEjemplar);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.txtBusqUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.FPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroPrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nroPrest;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnBuscarUser;
        public System.Windows.Forms.TextBox txtBusqEjemplar;
        public System.Windows.Forms.TextBox txtBusqUser;
        public System.Windows.Forms.Button btnGenerar;
        public System.Windows.Forms.Label labEstado;
        public System.Windows.Forms.Label labAutores;
        public System.Windows.Forms.Label labCodigo;
        public System.Windows.Forms.Label labTitulo;
        public System.Windows.Forms.Button btnBusqEjemplar;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label label4;
    }
}