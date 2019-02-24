using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Biblioteca biblioteca;
        static FileStream file;
        static string path = @"C:\Users\Facu\Desktop\TP3 - 10-12\TP3\bin\Debug\SaveFile.dat";
        static BinaryFormatter bin = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            RecuperarEstado();
            CargarListView();
        }

        static void RecuperarEstado()
        {
            if (File.Exists(path))
            {
                file = new FileStream("SaveFile.dat", FileMode.OpenOrCreate);
                biblioteca = (Biblioteca)bin.Deserialize(file);
            }
            else
            {
                biblioteca = new Biblioteca();
                file = new FileStream("SaveFile.dat", FileMode.OpenOrCreate);
            }
      
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEditarUsuario editar = new FEditarUsuario();

            if (editar.ShowDialog() == DialogResult.OK)
            {
                Usuario user = new Usuario(Convert.ToInt64(editar.txtDNI.Text), editar.txtNom.Text, editar.txtMail.Text);
                biblioteca.usuarios.Add(user);
            }

            CargarListView();
        }

        public void CargarListView()
        {
            listUsuarios.Items.Clear();
            listLibros.Items.Clear();

            foreach (Usuario user in biblioteca.usuarios)
            {
                ListViewItem item = new ListViewItem(user.Nombre);
                item.SubItems.Add(user.dni.ToString());
                if (user.estado == "Moroso")
                {
                    item.BackColor = Color.Red;
                }
                listUsuarios.Items.Add(item);
            }

            foreach (Libro libro in biblioteca.libros)
            {
                ListViewItem item = new ListViewItem(libro.titulo);
                item.SubItems.Add(libro.ISBN.ToString());

                if (!libro.tieneParaPrestar())
                {
                    item.BackColor = Color.Red;
                }

                listLibros.Items.Add(item);
            }
        }

        private void nuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEditarLibro editar = new FEditarLibro();
            if (editar.ShowDialog() == DialogResult.OK)
            {
                Libro libro = new Libro(Convert.ToInt64(editar.txtISBN.Text),
                                        Convert.ToInt32(editar.nroEjemplares.Value),
                                        editar.txtTitulo.Text, editar.txtAutores.Text);
                biblioteca.AddLibro(libro);
            }

            CargarListView();


        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();

            for (int i = 0; i < biblioteca.usuarios.Count; i++)
            {
                if (biblioteca.usuarios[i].dni.ToString().StartsWith(txtDni.Text))
                {
                    ListViewItem item = new ListViewItem(biblioteca.usuarios[i].Nombre);
                    item.SubItems.Add(biblioteca.usuarios[i].dni.ToString());

                    if (biblioteca.usuarios[i].estado == "Moroso")
                    {
                        item.BackColor = Color.Red;
                    }

                    listUsuarios.Items.Add(item);
                }
            }
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            listLibros.Items.Clear();

            for (int i = 0; i < biblioteca.libros.Count; i++)
            {
                if (biblioteca.libros[i].titulo.ToLower().StartsWith(txtTitulo.Text.ToLower()))
                {
                    ListViewItem item = new ListViewItem(biblioteca.libros[i].titulo);
                    item.SubItems.Add(biblioteca.libros[i].ISBN.ToString());

                    if (!biblioteca.libros[i].tieneParaPrestar())
                    {
                        item.BackColor = Color.Red;
                    }

                    listLibros.Items.Add(item);
                }
            }
        }

        private void listLibros_ItemActivate(object sender, EventArgs e)
        {
            int i = listLibros.SelectedIndices[0];
            string isbn = listLibros.Items[i].SubItems[1].Text;
            FLibro fLibro = new FLibro();

            fLibro.biblioteca = biblioteca;
            fLibro.isbn = Convert.ToInt64(isbn);
            fLibro.ShowDialog();
            CargarListView();
        }

        private void listUsuarios_ItemActivate(object sender, EventArgs e)
        {
            int i = listUsuarios.SelectedIndices[0];
            string dni = listUsuarios.Items[i].SubItems[1].Text;

            FUsuario fUsuario = new FUsuario();
            fUsuario.biblioteca = biblioteca;
            fUsuario.dni = Convert.ToInt64(dni);

            fUsuario.ShowDialog();

            CargarListView();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        string texto;
        Brush relleno;
        Pen borde;
        int paginas = 1;
        int j = 0;

        private void ImprimirMorosos_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(borde, new Rectangle(0, 0, 822, 1170));
            e.HasMorePages = false;
            Font fuente = new Font("Times New Roman", 15, FontStyle.Bold);
            SizeF tamañoLinea;
            float posX = 80;
            float posY = 50;
            tamañoLinea = e.Graphics.MeasureString("Lista de Socios Morosos", fuente);
            e.Graphics.DrawString("Lista de Socios Morosos", fuente, relleno, new PointF(posX+200, posY));
            posY = posY + tamañoLinea.Height;
            float linesPerPage = (e.MarginBounds.Height / fuente.GetHeight(e.Graphics))-3;
            e.Graphics.DrawString("Página " + paginas.ToString(), fuente, relleno, 700, 1110);
            for (int i = 0; i <= linesPerPage;i++ )
            {
                if (j<biblioteca.usuarios.Count)
                {
                    if (biblioteca.usuarios[i].EsMoroso())
                    {
                        texto = "Nombre: " + biblioteca.usuarios[j].Nombre + ".      DNI: " + biblioteca.usuarios[j].dni.ToString() + ".";
                        tamañoLinea = e.Graphics.MeasureString(texto, fuente);
                        if (i == 0)
                        {
                            posY = posY + 20;
                            e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                        }
                        else
                            e.Graphics.DrawString(texto, fuente, relleno, new PointF(posX, posY));
                        posY = posY + tamañoLinea.Height;
                    }
                }
                j++;
            }
            if (j < biblioteca.usuarios.Count)
            {
                e.HasMorePages = true;
                paginas++;
            }
            else
            {
                e.HasMorePages = false;
                j = 0;
                paginas = 1;
            }
        }

        private void ImprimirMorosos_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            relleno = new SolidBrush(Color.Black);
            borde = new Pen(Color.Gray,10);
        }

        private void ImprimirMorosos_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            borde.Dispose();
            relleno.Dispose();
        }

        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaPrevia.Document = ImprimirMorosos;
            VistaPrevia.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            file.Close();
            file = new FileStream(path, FileMode.Open);
            bin.Serialize(file, biblioteca);
            file.Close();
            file.Dispose();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            string str = DateTime.Now.ToString();
            str = str.Replace("/","-");
            str = str.Replace(" ", "_");
            str = str.Replace(":", "-");
            MessageBox.Show(str);
            FileStream backup = new FileStream(str,FileMode.Create);
            bin.Serialize(backup, biblioteca);
            backup.Close();
            backup.Dispose();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem1.PerformClick();

            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream backup = new FileStream(openFile.FileName, FileMode.Open);
                biblioteca = (Biblioteca)bin.Deserialize(backup);
            }

            CargarListView();
        }

        private void exportarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream exportar = new FileStream(saveFile.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(exportar);

                foreach (Libro libro in biblioteca.libros)
                {
                    writer.WriteLine(libro.Export());
                }
                writer.Close();
                exportar.Close();
                exportar.Dispose();
            }   
        }

        private void importarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog()==DialogResult.OK)
            {
                FileStream files = new FileStream(open.FileName, FileMode.Open);
                StreamReader leer = new StreamReader(files);
                string[] renglon;
                while (!leer.EndOfStream)
                {
                    renglon= leer.ReadLine().Split(';');
                    Libro l = new Libro(Convert.ToInt64(renglon[0]),Convert.ToInt32(renglon[3]),renglon[1],renglon[2]);
                    biblioteca.AddLibro(l);
                }
                leer.Close();
                files.Close();
                files.Dispose();

                CargarListView();
            }
        }

        private void imprimirMorososToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaPrevia.Document = ImprimirMorosos;
            if (VistaPrevia.ShowDialog() == DialogResult.OK)
            {
                ImprimirMorosos.Print();
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAyuda vAyuda = new FAyuda();
            string miPath = Application.StartupPath;
            string ayuda = miPath.Substring(0, miPath.Length - 9) + "index.htm";
            MessageBox.Show(ayuda);
            vAyuda.wBAyuda.Navigate(ayuda);
            vAyuda.ShowDialog();
            vAyuda.Dispose();
        }
    }
    /*public static class Global
    {
        public static Biblioteca biblioteca;
    }*/
}
