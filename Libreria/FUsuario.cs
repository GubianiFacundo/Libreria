using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FUsuario : Form
    {
        public long dni;
        public Biblioteca biblioteca;
        public Usuario user;

        public FUsuario()
        {
            InitializeComponent();
            //  grillaPrestamos.Columns.Clear();
            //grillaPrestamos.Rows.Clear();

            // headers de las filas
            grillaPrestamos.RowHeadersVisible = false;

            // headers de las columnas
            grillaPrestamos.ColumnCount = 4;
            grillaPrestamos.RowCount = 5;
            grillaPrestamos.ColumnHeadersVisible = true;
            grillaPrestamos.Columns[0].HeaderText = "T´titulo";
            grillaPrestamos.Columns[1].HeaderText = "Código";
            grillaPrestamos.Columns[2].HeaderText = "Fecha Prestamos";
            grillaPrestamos.Columns[3].HeaderText = "Fecha Devolución";
            grillaPrestamos.Columns[0].Width = 140;
            grillaPrestamos.Columns[1].Width = 140;
            grillaPrestamos.Columns[2].Width = 140;
            grillaPrestamos.Columns[3].Width = 140;
            grillaPrestamos.Width = 562;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FEditarUsuario editar = new FEditarUsuario();
            editar.txtNom.Text = user.Nombre;
            editar.txtDNI.Text = user.dni.ToString();
            //editar.txtDNI.Enabled = false;
            editar.txtMail.Text = user.email;

            editar.btnModificar.Text = "Modificar";

            if (editar.ShowDialog() == DialogResult.OK)
            {
                this.user.dni = Convert.ToInt64(editar.txtDNI.Text);
                this.user.Nombre = editar.txtNom.Text;
                this.user.email = editar.txtMail.Text;
            }

            ActualizarLabs();
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            user = biblioteca.buscarUsuario(dni);
            ActualizarLabs();
        }

        public void ActualizarLabs()
        {
            Libro lib;
            labNom.Text = user.Nombre;
            labDNI.Text = user.dni.ToString();
            labMail.Text = user.email;
            labEstado.Text = user.estado;

            grillaPrestamos.Rows.Clear();

            for (int i = 0; i < user.cantPrestamos; i++)
            {
                if(user.prestamos[i] != null)
                {
                    lib = biblioteca.buscarLibro(user.prestamos[i].ejemplar.NroPatrimonial);
                    string [] renglon = new string[4] {(lib.titulo.ToString()),
                                                        user.prestamos[i].ejemplar.NroPatrimonial.ToString(),
                                                        user.prestamos[i].fecpres.ToString("dd/MM/yyyy"),
                                                        (user.prestamos[i].fecdev.ToString("dd/MM/yyyy"))};
                    grillaPrestamos.Rows.Add(renglon);
                }              
            }
            if (user.cantPrestamos == 5)
                grillaPrestamos.AllowUserToAddRows = false;
            else
                grillaPrestamos.AllowUserToAddRows = true;
        }

        private void FUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Global.biblioteca.usuarios.Add(user);
        }

        private void grillaPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = grillaPrestamos.SelectedRows[0];

            if (currentRow.Cells.Count > 0) 
            {      
                bool rowIsEmpty = true;    

                foreach(DataGridViewCell cell in currentRow.Cells)    
                {
                    if(cell.Value != null) 
                    { 
                        rowIsEmpty = false;
                        break;
                    }    
                }

                if (rowIsEmpty)
                {
                    FPrestamo fPrestamos = new FPrestamo();
                    fPrestamos.usuario = user;
                    fPrestamos.biblioteca = biblioteca;
                    fPrestamos.txtBusqUser.Enabled = false;
                    fPrestamos.btnBuscarUser.Enabled = false;
                    fPrestamos.ShowDialog();

                }
                else
                {
                    user.RemovePrestamo(currentRow.Cells[1].Value.ToString());
                }
            }

            ActualizarLabs();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (previewPrestamos.ShowDialog() == DialogResult.OK)
                ImprimirPrestamos.Print();
        }
        string texto;
        Brush relleno;
        Pen borde;
        int paginas = 1;
        int j = 0;
        private void ImprimirPrestamos_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(borde, new Rectangle(0, 0, 822, 1170));
            e.HasMorePages = false;
            Font fuente = new Font("Times New Roman", 15, FontStyle.Bold);
            SizeF tamañoLinea;
            float posX = 50;
            float posY = 50;
            tamañoLinea = e.Graphics.MeasureString("Lista de Prestamos del usuario: " + user.Nombre, fuente);
            e.Graphics.DrawString("Lista de Prestamos del usuario: "+ user.Nombre, fuente, relleno, new PointF(posX + 200, posY));
            posY = posY + (tamañoLinea.Height*2);
            for (int i = 0; i < user.cantPrestamos; i++)
            {
                    Libro lib = biblioteca.buscarLibro(user.prestamos[i].ejemplar.NroPatrimonial);
                    texto = "Titulo: " + lib.titulo;
                    tamañoLinea = e.Graphics.MeasureString(texto, fuente);
                    e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                    posY = posY + tamañoLinea.Height;

                texto = "Codigo Patrimonial: " + user.prestamos[i].ejemplar.NroPatrimonial;
                    tamañoLinea = e.Graphics.MeasureString(texto, fuente);
                    e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                    posY = posY + tamañoLinea.Height;

                    texto = "Fecha de Prestamo: " + user.prestamos[i].fecpres.ToString("dd/MM/yyyy");
                    tamañoLinea = e.Graphics.MeasureString(texto, fuente);
                    e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                    posY = posY + tamañoLinea.Height;

                    texto = "Fecha de devolución: " + user.prestamos[i].fecdev.ToString("dd/MM/yyyy");
                    tamañoLinea = e.Graphics.MeasureString(texto, fuente);
                    e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                    posY = posY + ((tamañoLinea.Height)*(2));
                }
            }
 
        private void ImprimirPrestamos_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            relleno = new SolidBrush(Color.Black);
            borde = new Pen(Color.Gray, 10);
        }

        private void ImprimirPrestamos_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            borde.Dispose();
            relleno.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
