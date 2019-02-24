using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Usuario
    {
        public long dni;
        public string Nombre;
        public string email;
        public string estado = "Habilitado";

        public Prestamo[] prestamos = new Prestamo[5];
        public int cantPrestamos = 0;

        public Usuario(long dni, string Nombre, string email)
        {
            this.email = email;
            this.dni = dni;
            this.Nombre = Nombre;
        }

        public void AddPrestamo(Prestamo prest)
        {
            prestamos[cantPrestamos] = prest;
            cantPrestamos++;
            if (cantPrestamos == 5)
                estado = "Límite de Préstamos";
        }
        public void Banear(bool banear)
        {
            if (banear)
                estado = "BANEADO";
            else
                estado = "Habilitado";
        }

        public bool EsMoroso()
        {
            foreach (Prestamo p in prestamos)
            {
                if (p != null)
                {
                    if (p.Vencido())
                    {
                        if (estado != "BANEADO")
                            estado = "Moroso";
                        return true;
                    }
                }
            }

            if (estado != "BANEADO")
                estado = "Habilitado";
            return false;
        }

        
        public void RemovePrestamo(string codigo)
        {
            for (int i = 0; i < prestamos.Length; i++)
            {
                if (prestamos[i] != null)
                {
                    if (prestamos[i].ejemplar.NroPatrimonial == codigo)
                    {
                        prestamos[i].ejemplar.estaPrestado = false;
                        prestamos[i] = null;
                    }
                }
            }
            cantPrestamos--;
        }

    }
}
