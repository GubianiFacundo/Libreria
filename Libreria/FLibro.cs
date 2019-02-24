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
    public partial class FLibro : Form
    {
        public long isbn;
        public Libro libro = null;
        public Biblioteca biblioteca;

        public FLibro()
        {
            InitializeComponent();
            grillaLibros.RowHeadersVisible = false;
            grillaLibros.ColumnCount = 2;
            grillaLibros.ColumnHeadersVisible = true;
            grillaLibros.Columns[0].HeaderText = "Codigo";
            grillaLibros.Columns[1].HeaderText = "Ubicación";
            grillaLibros.Columns[0].Width = 161;
            grillaLibros.Columns[1].Width = 161;
            grillaLibros.AllowUserToAddRows = false;
        }

        private void FLibro_Load(object sender, EventArgs e)
        {
            libro = biblioteca.buscarLibro(isbn);
            CargarLabels();
        }

        private void FLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public void CargarLabels()
        {
            grillaLibros.Rows.Clear();
            labTitulo.Text = libro.titulo;
            labISBN.Text = libro.ISBN.ToString();
            labAutores.Text = libro.autores;
            if (libro.tieneParaPrestar())
                labEstado.Text = "Disponible";
            else
                labEstado.Text = "No Disponible";

            if (libro.ejemplares.Count > 0)
            {
                string[] renglon = new string[2];
                for (int i = 0; i < libro.ejemplares.Count; i++)
                {
                    if (!libro.ejemplares[i].deBaja)
                    {
                        renglon[0] = libro.ejemplares[i].NroPatrimonial;
                        renglon[1] = libro.ejemplares[i].ubicacion;

                        grillaLibros.Rows.Add(renglon);
                        if (libro.ejemplares[i].estaPrestado)
                            grillaLibros.Rows[grillaLibros.Rows.Count-1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }
            else
                MessageBox.Show("Lamentablemente no se cuenta con ningún ejemplar.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FEditarLibro editar = new FEditarLibro();
            editar.txtTitulo.Text = libro.titulo; editar.txtTitulo.Enabled = false;
            editar.txtAutores.Text = libro.autores; editar.txtAutores.Enabled = false;
            editar.txtISBN.Text = libro.ISBN.ToString(); editar.txtISBN.Enabled = false;
            editar.txtUbicacion.Text = libro.ubicacion; editar.txtUbicacion.Enabled = false;
            bool seguir = true;
            do
            {
                if (editar.ShowDialog() == DialogResult.OK)
                {
                    libro.addEjemplar((int)editar.nroEjemplares.Value);
                    
                    seguir = true;
                }
                else
                {
                    DialogResult dialogo = MessageBox.Show("Usted esta seguro que desea salir?", "", MessageBoxButtons.YesNo);
                    if (dialogo == DialogResult.No)
                        seguir = false;
                    else
                        seguir = true;
                }
            }
            while(!seguir);

            CargarLabels();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = grillaLibros.SelectedRows[0];
            Ejemplar ejemplar = biblioteca.buscarEjemplar(currentRow.Cells[0].Value.ToString());

            ejemplar.darDeBaja();

            CargarLabels();
        }

        private void grillaLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = grillaLibros.SelectedRows[0];
            Ejemplar ejemplar = biblioteca.buscarEjemplar(currentRow.Cells[0].Value.ToString());
            if (ejemplar.estaPrestado||!libro.tieneParaPrestar())
                MessageBox.Show("No es posile realizar el prestamo de este ejemplar");
            else
            {
                Libro lib = biblioteca.buscarLibro(currentRow.Cells[0].Value.ToString());
                FPrestamo prest = new FPrestamo();
                prest.biblioteca = biblioteca;
                prest.isbn = isbn;
                prest.labTitulo.Text = lib.titulo;
                prest.labCodigo.Text = currentRow.Cells[0].Value.ToString();
                prest.labAutores.Text = lib.autores;
                prest.labEstado.Text = "Disponilbe";
                prest.txtBusqEjemplar.Enabled = false;
                prest.btnBusqEjemplar.Enabled = false;
                prest.ejemplar = ejemplar;
                prest.ShowDialog();
                CargarLabels();
            }
        }

        private void Salir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}