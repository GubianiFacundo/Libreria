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
    public partial class FPrestamo : Form
    {
        public Usuario usuario;
        public Ejemplar ejemplar;
        public Biblioteca biblioteca;
        public long isbn;

        public FPrestamo()
        {
            InitializeComponent();
            btnGenerar.Enabled = false;

        }
        
        private void FPrestamo_Load(object sender, EventArgs e)
        {
            usuario = biblioteca.buscarUsuario(usuario);

            if (usuario != null)
            {
                labNom.Text = usuario.Nombre;
                labDNI.Text = usuario.dni.ToString();
                labMail.Text = usuario.email;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Usted está seguro que desea generar el préstamo?", "", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Prestamo pres = new Prestamo(usuario, ejemplar, Convert.ToInt32(nroPrest.Value));
                usuario.AddPrestamo(pres);
                ejemplar.estaPrestado = true;
                Close();
            }

        }

        private void FPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnBusqEjemplar_Click(object sender, EventArgs e)
        {
            if (txtBusqEjemplar.Text.Contains('-'))
            {
                ejemplar = biblioteca.buscarEjemplar(txtBusqEjemplar.Text);
                if (ejemplar != null)
                {
                    Libro milibro = biblioteca.buscarLibro(ejemplar.NroPatrimonial);
                    labTitulo.Text = milibro.titulo;
                    labAutores.Text = milibro.autores;
                    labCodigo.Text = ejemplar.NroPatrimonial;
                    if (ejemplar.estaPrestado)
                    {
                        labEstado.Text = "Prestado";
                        btnGenerar.Enabled = false;
                    }
                    else if (ejemplar.deBaja)
                    {
                        labEstado.Text = "Dado de baja";
                        btnGenerar.Enabled = false;
                    }
                    else
                    {
                        labEstado.Text = "Habilitado para Prestamo";
                        btnGenerar.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Libro No Encontrado! Verifique el codigo.");
            }
            else
                MessageBox.Show("Libro No Encontrado! Verifique el codigo.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Usted está seguro que desea salir?","", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                Close();
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            Usuario user = biblioteca.buscarUsuario(Convert.ToInt64(txtBusqUser.Text));
            if (user != null)
            {
                labNom.Text = user.Nombre;
                labMail.Text = user.email;
                labDNI.Text = txtBusqUser.Text;
                txtBusqUser.Text = "";
                if (user.EsMoroso())
                {
                    MessageBox.Show("Usuario Moroso!!");
                    btnGenerar.Enabled = false;
                }
                else
                {
                    btnGenerar.Enabled = true;
                    usuario = user;
                }
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("Desea crear un nuevo ususario?","Usuario no encontrado",MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    FEditarUsuario nuevo = new FEditarUsuario();
                    nuevo.txtDNI.Text = txtBusqUser.Text;
                    if (nuevo.ShowDialog() == DialogResult.OK)
                    {
                        Usuario user1 = new Usuario(Convert.ToInt64(nuevo.txtDNI.Text), nuevo.txtNom.Text, nuevo.txtMail.Text);
                        biblioteca.AddUsuario(user1);
                        usuario = user1;

                        labNom.Text = usuario.Nombre;
                        labDNI.Text = usuario.dni.ToString();
                        labMail.Text = usuario.email;
                        
                    }
                }
            }
        }

        private void txtBusqUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBusqEjemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
